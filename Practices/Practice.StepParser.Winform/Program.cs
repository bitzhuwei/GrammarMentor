using bitzhuwei.Compiler;
using bitzhuwei.StepFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Practice.StepParser.Winform
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Test.PrintStep(); return;
            //Test.CollectRefs(); return;
            //Test.CollectTypes(); return;
            //TestPostOrderStack(); return;
            //CollectTypes(); return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }



        //private static void TestPostOrderStack()
        //{
        //    var node0 = new Node(0);
        //    {
        //        var node1 = new Node(1);
        //        var node2 = new Node(2);
        //        var node3 = new Node(3);
        //        node0.Children.Add(node1);
        //        node0.Children.Add(node2);
        //        node0.Children.Add(node3);
        //        {
        //            var node4 = new Node(4);
        //            var node5 = new Node(5);
        //            var node6 = new Node(6);
        //            var node7 = new Node(7);
        //            var node8 = new Node(8);
        //            node1.Children.Add(node4);
        //            node1.Children.Add(node5);
        //            node2.Children.Add(node6);
        //            node2.Children.Add(node7);
        //            node2.Children.Add(node8);
        //        }
        //    }
        //    PostOrderStack(node0);
        //}

        //static void PostOrderStack(Node rootNode)
        //{
        //    var nodeStack = new Stack<Node>();
        //    var indexStack = new Stack<int>();
        //    // init stack.
        //    {
        //        // push nextLeft and its next pending children.
        //        var nextLeft = rootNode;
        //        nodeStack.Push(nextLeft); indexStack.Push(0);
        //        while (nextLeft.Children.Count > 0)
        //        {
        //            nextLeft = nextLeft.Children[0];
        //            nodeStack.Push(nextLeft);
        //            indexStack.Push(0);
        //        }
        //    }

        //    while (nodeStack.Count > 0)
        //    {
        //        var current = nodeStack.Pop();
        //        var index = indexStack.Pop() + 1;
        //        if (index < current.Children.Count)
        //        {
        //            // push this node back again.
        //            nodeStack.Push(current); indexStack.Push(index);

        //            // push nextLeft and its next pending children.
        //            var nextLeft = current.Children[index];
        //            nodeStack.Push(nextLeft); indexStack.Push(0);
        //            while (nextLeft.Children.Count > 0)
        //            {
        //                nextLeft = nextLeft.Children[0];
        //                nodeStack.Push(nextLeft);
        //                indexStack.Push(0);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{current}");
        //            //Action<Node, StepContext> action;
        //            //if (extracterDict.TryGetValue(current.type, out action))
        //            //{
        //            //    action(current, context);
        //            //}
        //        }
        //    }
        //}

        // 整理了Types.txt文件
        //private static void MergeFiles()
        //{
        //    var list = new List<string>();
        //    foreach (var pair in System.IO.Directory.GetFiles(".", "Types*.txt"))
        //    {
        //        using (var reader = new System.IO.StreamReader(pair))
        //        {
        //            while (!reader.EndOfStream)
        //            {
        //                string line = reader.ReadLine();
        //                if (!list.Contains(line))
        //                {
        //                    list.Add(line);
        //                }
        //            }
        //        }
        //    }
        //    list.Sort();
        //    using (var w = new System.IO.StreamWriter("Types.txt"))
        //    {
        //        foreach (var pair in list)
        //        {
        //            w.WriteLine(pair);
        //        }
        //    }
        //}
    }
}
