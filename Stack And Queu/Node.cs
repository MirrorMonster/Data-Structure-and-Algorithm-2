using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_And_Queu
{
    public class Node
    {
        private int value;
        private char cVal;
        private Node next;

        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }

       

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }


    }
}
