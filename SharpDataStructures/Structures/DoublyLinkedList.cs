using System.Reflection.Metadata;

namespace SharpDataStructures.Structures;

public class DoublyLinkedList
{
    private class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }
        public Node? Previous { get; set; }
    }

    private Node? _root = null;

    public void Append(int value)
    {
        if (_root == null)
        {
            _root = new Node
            {
                Value = value,
                Previous = null,
                Next = null
            };
            return;
        }

        Node? targetNode = _root;
        while (true)
        {
            if (targetNode.Next == null)
            {
                targetNode.Next = new Node
                {
                    Value = value,
                    Next = null,
                    Previous = targetNode
                };
                break;
            }

            targetNode = targetNode.Next;
        }
    }

    public bool Contains(int value)
    {
        Node? targetNode = _root;
        while (true)
        {
            if (targetNode == null)
            {
                return false;
            }
            if (targetNode.Value == value)
            {
                return true;
            }
            else
            {
                targetNode = targetNode.Next;
            }
        }
    }

    public void Delete(int value)
    {
        Node? targetNode = _root;
        while (true)
        {
            if (targetNode == null)
            {
                return;
            }
            if (targetNode.Value == value)
            {
                if (targetNode.Next == null)
                {
                    targetNode.Previous.Next = null;
                }
                else
                {
                    targetNode.Next.Previous = targetNode.Previous;
                    targetNode.Previous.Next = targetNode.Next;
                }
            }

            targetNode = targetNode.Next;
        }
    }
}