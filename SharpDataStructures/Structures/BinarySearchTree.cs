namespace SharpDataStructures.Structures;

public class BinarySearchTree
{ 
    /*
     *   Basic Implementation of a Binary Search Tree
    */
    
    private Node? _root;
    public int Height { get; set; }

    public void Insert(int value)
    {
        if (_root == null)
        {
            _root = new Node
            {
                Value = value
            };
            Height += 1;
            return;
        }

        var targetNode = _root;
        while (targetNode != null)
            if (value < targetNode.Value)
            {
                if (targetNode.LeftChild == null)
                {
                    targetNode.LeftChild = new Node
                    {
                        Value = value
                    };

                    Height += 1;
                    targetNode = null;
                }
                else
                {
                    targetNode = targetNode.LeftChild;
                }
            }
            else
            {
                if (targetNode.RightChild == null)
                {
                    targetNode.RightChild = new Node
                    {
                        Value = value
                    };

                    Height += 1;
                    targetNode = null;
                }
                else
                {
                    targetNode = targetNode.RightChild;
                }
            }
    }

    public bool Contains(int value)
    {
        var targetNode = _root;
        while (targetNode != null)
        {
            if (targetNode.Value == value) return true;

            if (value < targetNode.Value)
                targetNode = targetNode.LeftChild;
            else
                targetNode = targetNode.RightChild;
        }

        return false;
    }
    
    private class Node
    {
        public int Value { get; init; }
        public Node? LeftChild { get; set; }
        public Node? RightChild { get; set; }
    }
}

