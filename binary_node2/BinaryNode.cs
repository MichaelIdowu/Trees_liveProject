using System;

namespace binary_node2
{
    internal class BinaryNode<T>
    {
        internal T Value { get; set; }
        internal BinaryNode<T> LeftChild, RightChild;

        internal BinaryNode(T value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }
        internal void AddLeft(BinaryNode<T> child)
        {
            LeftChild = child;
        }

        internal void AddRight(BinaryNode<T> child)
        {
            RightChild = child;
        }

        public override string ToString()
        {
            return ToString(" ");
        }
        // Recursively create a string representation of this node's subtree.
        // Display this value indented, followed by the left and right
        // values indented one more level.
        // End in a newline.
        public string ToString(string spaces)
        {

            // Create a string named result that initially holds the
            // current node's value followed by a new line.
            string result = string.Format("{0}{1}:\n", spaces, Value);

            // See if the node has any children.
            if ((LeftChild != null) || (RightChild != null))
            {
                // Add null or the child's value.
                if (LeftChild == null)
                    result += string.Format("{0}{1}null\n", spaces, "  ");
                else
                    result += LeftChild.ToString(spaces + "  ");

                // Add null or the child's value.
                if (RightChild == null)
                    result += string.Format("{0}{1}null\n", spaces, "  ");
                else
                    result += RightChild.ToString(spaces + "  ");
            }
            return result;
        }
    }

}
