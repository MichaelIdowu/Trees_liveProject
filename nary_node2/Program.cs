using System;

namespace nary_node2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_NaryTree();

            Console.ReadKey();
        }

        static void Test_NaryTree()
        {
            Console.WriteLine();
            Console.WriteLine("N-ARY TREE");

            //   Root
            //    |
            // +--+--+
            // A  B C
            // |    |
            //+-+   +
            //D E   F
            //|     |
            //+    +-+
            //G    H I

            // Create two nodes named "root" and "a."
            NaryNode<string> root = new NaryNode<string>("Root");
            //Create and make "a,b,c" be children of "root."
            NaryNode<string> a = new NaryNode<string>(root, "A");
            NaryNode<string> b = new NaryNode<string>(root, "B");
            NaryNode<string> c = new NaryNode<string>(root, "C");
            NaryNode<string> d = new NaryNode<string>(a, "D");
            NaryNode<string> e = new NaryNode<string>(a, "E");
            NaryNode<string> f = new NaryNode<string>(c, "F");
            NaryNode<string> g = new NaryNode<string>(d, "G");
            NaryNode<string> h = new NaryNode<string>(f, "H");
            NaryNode<string> i = new NaryNode<string>(f, "I");

            Console.WriteLine(root);
            Console.WriteLine(a);            
            Console.WriteLine(f.ToString(">>"));
        }
    }
}
