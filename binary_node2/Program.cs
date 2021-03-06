using System;

namespace binary_node2
{

    class Program
    {
        static void Main(string[] args)
        {
            Test_BinaryTree();

            Console.ReadKey();
        }

        static void Test_BinaryTree()
        {
            Console.WriteLine();
            Console.WriteLine("BINARY TREE");

            // Create nodes named "root", "a", ...
            // Build a test tree.
            //      Root
            //      /  \
            //     A    B
            //    / \    \
            //   C   D    E
            //           /
            //          F
            BinaryNode<string> root = new BinaryNode<string>("Root");
            BinaryNode<string> a = new BinaryNode<string>("A");
            BinaryNode<string> b = new BinaryNode<string>("B");
            BinaryNode<string> c = new BinaryNode<string>("C");
            BinaryNode<string> d = new BinaryNode<string>("D");
            BinaryNode<string> e = new BinaryNode<string>("E");
            BinaryNode<string> f = new BinaryNode<string>("F");

            root.AddLeft(a);
            root.AddRight(b);
            a.AddLeft(c);
            a.AddRight(d);
            b.AddRight(e);
            e.AddLeft(f);

            // Verify the tree.
            // Verify the tree.
            Console.WriteLine(root);
            Console.WriteLine(a);
            Console.WriteLine(b.ToString(" - "));
        }

    }
}
