using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class node
    {
        /* Node class repsent the node of doubly linked list
         * it consists of the information part and and links to
         * its succeding and preseeding 
         * in terms of next and previous */

        public int noMhs;
        public string name;
        //point to the succeding node
        public node next;
        //point to the preceeding node
        public node prev;
    }
    class DoubleLinkedList
    {
        node START;

        //constructor

        public void addNote()
        {
            int nim;
            string nm;
            Console.WriteLine("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of teh student: ");
            nm = Console.ReadLine();
            node newNode = new node();
            newNode.noMhs = nim;
            newNode.name = nm;

            //check if the list empty 
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowed");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.next = null;
                START = newNode;
                return;
            }
            //if the node is to be inserted at between two Node*/
            node previous, current;
            for (current = previous = START;
                current != null && nim >= current.noMhs;
            previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                }
            }
            /* On the execution of the above for loop, prev and
             * current will point to those nodes
             * between which the new node is to be inserted*/
            newNode.next = current;
            newNode.prev = previous;         
        }
        public bool Search (int rollNo, ref node previous, ref node current)
        {
            previous = current = START;
            while (current != null &&
                rollNo != current.noMhs)
            {
                previous = current;
                current = current.next;
            }
            return (current != null);
        }
        public bool dellNode(int rollNo)
        {
            node previous, current;
            previous = current = null;
            if (Search(rollNo, ref previous, ref current) == false)
                return false;
            //The beginning of Data
            if (current.next == null)
            {
                previous.next = null;
                return true;
            }
            //node between two nodes in the list 
            if (current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true;
            }
            //*if the to be deleted is in between the list then the following lines of is execute. /
            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }
    }
}
