using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// LR分析动作的基类
    /// </summary>
    public abstract class LRParsingActionDraft {
        /// <summary>
        /// 为自动生成分析表而添加的抽象方法。代表(S1, G1, R[1] ...)中的数字。
        /// </summary>
        /// <returns></returns>
        public abstract string ActionParam();
        public abstract void ToMermaid(TextWriter w, object context);
    }

    /// <summary>
    /// 移进
    /// </summary>
    public class LRShiftInActionDraft : LRParsingActionDraft {

        public override string ActionParam() {
            return this.nextStateIndex.ToString();
        }

        public override void ToMermaid(TextWriter w, object context) {
            w.Write($"S{this.nextStateIndex}");
        }

        public readonly int nextStateIndex;

        public LRShiftInActionDraft(int nextStateIndex) {
            this.nextStateIndex = nextStateIndex;
        }

        public void Print(System.IO.TextWriter w) {
            w.Write($"Shift to SyntaxStates[{nextStateIndex}]");
        }

        public override string ToString() {
            return ($"Shift to SyntaxStates[{nextStateIndex}]");
        }
    }

    /// <summary>
    /// 归约
    /// </summary>
    public class LRReducitonActionDraft : LRParsingActionDraft {

        public override string ActionParam() {
            return this.regulationIndex.ToString();
        }

        public override void ToMermaid(TextWriter w, object context) {
            w.Write($"R[{this.regulationIndex}]");
        }

        /// <summary>
        /// 根据哪个规则进行归约？
        /// <para>redction according to which <see cref="VnRegulationDraft"/>(or <see cref="bitzhuwei.Compiler.Regulation"/>)</para>
        /// <para>[0, regulations.Length - 1]</para>
        /// </summary>
        public readonly int regulationIndex;

        public LRReducitonActionDraft(int regulationIndex) {
            this.regulationIndex = regulationIndex;
        }

        public void Print(System.IO.TextWriter w) {
            w.Write($"Reduction by R[{regulationIndex}]");
        }

        public override string ToString() {
            return ($"Reduction by R[{regulationIndex}]");
        }
    }

    /// <summary>
    /// 转到
    /// </summary>
    public class LRGotoActionDraft : LRParsingActionDraft {

        public override string ActionParam() {
            return this.GoToStateIndex.ToString();
        }

        public override void ToMermaid(TextWriter w, object context) {
            w.Write($"G{this.GoToStateIndex}");
        }

        public readonly int GoToStateIndex;

        public LRGotoActionDraft(int gotoStateIndex) {
            this.GoToStateIndex = gotoStateIndex;
        }

        public void Print(System.IO.TextWriter w) {
            w.Write($"Go to SyntaxStates[{GoToStateIndex}]");
        }

        public override string ToString() {
            return ($"Go to SyntaxStates[{GoToStateIndex}]");
        }
    }

    /// <summary>
    /// 接受（分析完毕）
    /// </summary>
    public class LRAcceptActionDraft : LRParsingActionDraft {
        public override string ActionParam() {
            return "/*no param*/";
        }

        public override void ToMermaid(TextWriter w, object context) {
            //w.Write("Accept");
            w.Write("完成");
        }

        public void Print(System.IO.TextWriter w) {
            w.Write("Accept");
        }

        public override string ToString() {
            return string.Format("Accept");
        }
    }

    /// <summary>
    /// 错误（语法错误）
    /// </summary>
    public class LRDefaultErrorActionDraft
        : LRParsingActionDraft {

        public override string ActionParam() {
            return "/*Error*/";
        }

        public override void ToMermaid(TextWriter w, object context) {
            w.Write("Error");
        }

        public void Print(System.IO.TextWriter w) {
            w.Write("Error");
        }

        public override string ToString() {
            return string.Format("Error");
        }
    }
}
