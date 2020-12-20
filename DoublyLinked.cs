using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCloneUI
{
    public class Node
    {
        
        public Node()
        {

        }
        public string data;
        public Node next;
        public Node prev;
    };
    public class DoublyLinked
    {
        public DoublyLinked()
        {

        }
        
        public Node start;

        // Structure of a Node  
       

        // Function to insert at the end  
        public void insertEnd(string value)
        {
            Node new_node;


            if (start == null)
            {
                new_node = new Node();
                new_node.data = value;
                new_node.next = new_node.prev = new_node;
                start = new_node;
                return;
            }


            Node last = (start).prev;


            new_node = new Node();
            new_node.data = value;


            new_node.next = start;


            (start).prev = new_node;


            new_node.prev = last;


            last.next = new_node;
        }


        public void insertBegin(string value)
        {


            Node last = (start).prev;

            Node new_node = new Node();
            new_node.data = value;


            new_node.next = start;
            new_node.prev = last;


            last.next = (start).prev = new_node;


            start = new_node;
        }


        public void insertAfter(string value1, string value2)
        {
            Node new_node = new Node();
            new_node.data = value1;


            Node temp = start;
            while (temp.data != value2)
                temp = temp.next;
            Node next = temp.next;


            temp.next = new_node;
            new_node.prev = temp;
            new_node.next = next;
            next.prev = new_node;
        }


    }

}
