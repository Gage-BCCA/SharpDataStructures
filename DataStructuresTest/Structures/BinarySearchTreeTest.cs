using SharpDataStructures.Structures;

namespace DataStructuresTest.Structures;

public class BinarySearchTreeTest
{
    [Fact]
    public void Height_TwoElements_ReturnTwo()
    {
        BinarySearchTree tree = new BinarySearchTree();
        tree.Insert(10);
        tree.Insert(20);
        Assert.Equal(2, tree.Height);
    }

    [Fact]
    public void Contains_ElementPresent_ReturnTrue()
    {
        BinarySearchTree tree = new BinarySearchTree();
        tree.Insert(10);
        tree.Insert(15);
        tree.Insert(5);
        Assert.True(tree.Contains(10), "The tree does, in fact, contain 10.");
    }
}