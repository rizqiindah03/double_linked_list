using System;
using System.Collections.Generic;
using System.Linq;
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
}
