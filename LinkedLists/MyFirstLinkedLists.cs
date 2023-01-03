using static LinkedLists.MyFirstLinkedLists;

namespace LinkedLists
{
    public class MyFirstLinkedLists
    {

        internal class Node // Singly-linked list node
        {
            internal int data; // data part of node
            internal Node next; // link part of node
            public Node(int d)
            {
                data = d;
                next = null;
            }
        } // so far, node is on its own, pointing to null as the next node



        internal class DNode // Doubly linked list node
        {
            internal int data; // data part of node
            internal DNode prev; // link to previous node
            internal DNode next; // link to next node
            public DNode(int d)
            {
                data = d;
                prev = null;
                next = null;
            }
        } // so far node is on its own, pointing to null as previous and next node


        internal class SingleLinkedList // Linked List has just a head when instantiated (which is null)
        {
            internal Node head; // will later contain nodes from Node class above
        }

        internal class DoubleLinkedList // A doubly linked list is instantiated in the same way
        {
            internal DNode head; // with nodes from the DNode class above to be added later
        }

        // Adding data at the front of the linked list:
        // The head of an empty Single Linked List is null (currently)

        internal void InsertFront(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = singlyList.head; // So when a new node is added at the front, its NEXT will point to the HEAD 
            singlyList.head = new_node; // which then assigns HEAD to the new node -- manually done!!!!
        }

        // For a double linked list, when adding a node to the front

        internal void InsertFront(DoubleLinkedList doubleLinkedList, int data)
        {
            DNode newNode = new DNode(data); 
            newNode.next = doubleLinkedList.head; // Same as the Single Linked List, adding a node to the front will need NEXT to point to HEAD
            newNode.prev = null; // Previous address remains null as this node will be the HEAD and points to nothing previously
            
            if (doubleLinkedList.head != null) 
            {
                doubleLinkedList.head.prev = newNode;// here, point the PREV pointer of current HEAD to the new node (since it is now first and will be HEAD)
            }
            doubleLinkedList.head = newNode; // then same as the SLL, the new node becomes HEAD
        }

        // Insert at the end of a Single Linked List
        internal void InsertLast(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            if (singlyList.head == null) // if the list is empty, add new node as Head
            {
                singlyList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }

        internal Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }




    }
}