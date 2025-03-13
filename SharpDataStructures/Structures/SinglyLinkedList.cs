using System.Net.Sockets;

namespace SharpDataStructures.Structures;

public class SinglyLinkedList
{
    /*
     *   Singly linked list that does not have to be contiguous in memory
     */
    
    private Node? _root;

    public int Count { get; set; } = 0;

    public void Append(int value)
    {
        Count += 1;
        if (_root == null)
        {
            _root = new Node
            {
                Value = value
            };
            
            return;
        }

        Node? target = _root;
        while (target != null)
        {
            if (target.Next == null)
            {
                target.Next = new Node
                {
                    Value = value
                };
                target = null;
                continue;
            }

            target = target.Next;

        }
    }

    public void Prepend(int value)
    {
        Node newRoot = new Node
        {
            Value = value,
            Next = _root
        };
        _root = newRoot;
    }

    public void Remove(int value)
    {
        
        Node? target = _root;
        if (target == null)
        {
            return;
        }
        if (target.Value == value)
        {
            _root = target.Next;
            return;
        }
        while (true)
        {
            if (target == null)
            {
                break;
            }
            
            if (target.Next != null)
            {
                if (target.Next.Value == value)
                {
                    target.Next = target.Next.Next;
                    Count -= 1;
                }
                target = target.Next;
            }
            else
            {
                break;
            }
        }
    }
    
    private class Node
    {
        public required int Value { get; set; }
        public Node? Next { get; set; }
    }
}

