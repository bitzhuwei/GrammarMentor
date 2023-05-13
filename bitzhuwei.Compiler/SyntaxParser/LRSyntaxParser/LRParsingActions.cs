using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// 移进
    /// </summary>
    public class LRShiftInAction : ParsingAction {
        public readonly SyntaxState nextState;
        //public readonly int nextStateId;
        public LRShiftInAction(SyntaxState nextState) {
            this.nextState = nextState;
        }

        public override int Execute(LRSyntaxContext context) {
            //ENodeType nodeType = context.CurrentToken.type.Convert();
            string nodeType = context.CurrentToken.type;// auto-convert from string to string.
            var newNode = new Node(nodeType, context.Index);
            newNode.tokenCount = 1;
            context.nodeStack.Push(newNode);
            //Console.Write($"读入{nodeType}：从状态{context.stateStack.Peek().id}");
            context.stateStack.Push(this.nextState);
            //Console.WriteLine($"移进至状态{this.nextState.id}；");

            return context.Index + 1;
        }

        public override string ToString() {
            return string.Format("Shift in: next state: [{0}]", nextState);
        }
    }

    /// <summary>
    /// 归约
    /// </summary>
    public class LRReducitonAction : ParsingAction {
        /// <summary>
        /// 根据哪个规则进行归约？
        /// <para>redction according to which <see cref="bitzhuwei.Compiler.Regulation"/></para>
        /// </summary>
        private readonly Regulation regulation;

        public LRReducitonAction(Regulation regulation) {
            this.regulation = regulation;
        }

        public override int Execute(LRSyntaxContext context) {
            var regulation = this.regulation;
            //Console.Write($"状态{context.stateStack.Peek().id}规约：{regulation}，");
            var type = regulation.left;
            var newNode = new Node(type);
            newNode.regulation = regulation;
            int tokenCount = 0;
            int count = regulation.right.Length;
            for (int i = 0; i < count; i++) {
                var node = context.nodeStack.Pop();
                var state = context.stateStack.Pop();//只弹出，不再使用。
                newNode.Children.Insert(0, node);
                node.parent = newNode;
                tokenCount += node.tokenCount;
                if (i == count - 1) { newNode.tokenIndex = node.tokenIndex; }
            }
            newNode.tokenCount = tokenCount;
            context.nodeStack.Push(newNode);
            // TODO: isn't this wired?
            {
                var state = context.stateStack.Peek();
                //Console.WriteLine($"回到状态{context.stateStack.Peek().id}；");
                var gotoAction = context.GetAction(state, regulation.left);
                gotoAction.Execute(context);
            }

            return context.Index;
        }

        public override string ToString() {
            return $"Reduction regulation: {regulation}";
        }
    }

    /// <summary>
    /// 转到
    /// </summary>
    public class LRGotoAction : ParsingAction {
        private readonly SyntaxState gotoState;

        public LRGotoAction(SyntaxState gotoState) {
            this.gotoState = gotoState;
        }

        public override int Execute(LRSyntaxContext context) {
            //Console.Write($"从状态{context.stateStack.Peek().id}");
            context.stateStack.Push(gotoState);
            //Console.WriteLine($"跳入状态{gotoState.id};");

            return context.Index;
        }

        public override string ToString() {
            return $"Goto state: {gotoState}";
        }
    }

    /// <summary>
    /// 接受（分析完毕）
    /// </summary>
    public class LRAcceptAction : ParsingAction {
        public override int Execute(LRSyntaxContext context) {
            //return context.Index + 1;
            var state = context.stateStack.Pop(); // this 'state' var is not in use for now.
            // point to the endOfTokenList Token. <- Not for sure(2023年4月8日22:22:05)
            //Console.WriteLine($"完成，回到状态{context.stateStack.Peek().id}");
            return context.Index;
        }

        public override string ToString() {
            return "Accept";
        }
    }

    /// <summary>
    /// 错误（语法错误）
    /// </summary>
    public class LRDefaultErrorAction : ParsingAction {
        public override int Execute(LRSyntaxContext context) {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return "Error";
        }
    }
}
