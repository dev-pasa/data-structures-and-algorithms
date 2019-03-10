using System;
using Xunit;
using LinkedList;
using ShuffleList;

namespace XUnitTestShuffleLinkedList
{ 
    public class UnitTest1
{
    [Fact]
    public void ShuffleTest1()
    {
        Node node1 = new Node(1);
        Node node2 = new Node(2);
        Node node3 = new Node(3);
        Node node4 = new Node(4);

        MyLinkedList list = new MyLinkedList(null);
        list.Head = new Node(5);
        list.Insert(node4);
        list.Insert(node3);
        list.Insert(node2);
        list.Insert(node1);
        list.Print();

        ShuffleList.Program.ShuffleLinkedList(list.Head);
    }

    [Fact]
    public void ShuffleTest2()
    {
        Node node1 = new Node(7);
        Node node2 = new Node(8);
        Node node3 = new Node(39);
        Node node4 = new Node(40);

        MyLinkedList list = new MyLinkedList(null);
        list.Head = new Node(10);
        list.Insert(node4);
        list.Insert(node3);
        list.Insert(node2);
        list.Insert(node1);
        list.Print();

        ShuffleList.Program.ShuffleLinkedList(list.Head);
    }

    [Fact]
    public void ShuffleTest3()
    {
        Node node1 = new Node(12);
        Node node2 = new Node(12);
        Node node3 = new Node(13);
        Node node4 = new Node(14);

        MyLinkedList list = new MyLinkedList(null);
        list.Head = new Node(15);
        list.Insert(node4);
        list.Insert(node3);
        list.Insert(node2);
        list.Insert(node1);
        list.Print();

        ShuffleList.Program.ShuffleLinkedList(list.Head);
    }
}
}
