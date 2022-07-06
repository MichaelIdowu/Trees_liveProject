using System;
using System.Collections.Generic;

namespace nary_node1
{
    internal class NaryNode<T>
    {
        internal T Value { get; set; }
        internal List<NaryNode<T>> Children;

        internal NaryNode(T value)
        {
            Value = value;
            Children = new List<NaryNode<T>>();
        }

        internal NaryNode(NaryNode<T> parent, T value)
        {
            Value = value;
            Children = new List<NaryNode<T>>();

            if (parent != null)
            {
                parent.AddChild(this);
            }
        }

        internal void AddChild(NaryNode<T> child)
        {
            Children.Add(child);
        }

        // Return a string representation of the node and its children.
        public override string ToString()
        {
            string result = string.Format("{0}:", Value);
            foreach (NaryNode<T> child in Children)
                result += string.Format(" {0}", child.Value);
            return result;
        }

        //After you implement the ToString method, you can display the contents of node a by using the following statement.
        //Console.WriteLine(a);

    }

}
