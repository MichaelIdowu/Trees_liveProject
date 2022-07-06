using System;
using System.Collections.Generic;

namespace nary_node2
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
            return ToString(" ");
        }

        // Recursively create a string representation of this node's subtree.
        // Display this value indented, followed its children indented one more level.
        // End in a newline.
        public string ToString(string spaces)
        {
            // Create a string named result that initially holds the
            // current node's value followed by a new line.
            string result = string.Format("{0}{1}:\n", spaces, Value);

            // Add the children representations
            // indented by one more level.
            foreach (NaryNode<T> child in Children)
                result += child.ToString(spaces + "  ");
            return result;
        }

    }

}
