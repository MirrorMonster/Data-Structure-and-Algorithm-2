using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_And_Queu
{
    public class CustomStack
    {
        protected Node head;

        protected int Length;

        
        public CustomStack()
        {
            head = null;
            Length = 0;
        }

        public void Push(int x)
        {
            Node p = new Node(x);
            if (head == null)
                head = p;
            else
            {
                p.Next = head;
                head = p;
            }
            Length++;
        }

       

        public int Pop()
        {
            int result = head.Value;
            head = head.Next;
            Length--;
            return result;
            
        }

        public void Show()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.Value);
                p = p.Next;
            }
        }

        public int Peek()
        {
            return head.Value;
        }

        public bool IsNullable()
        {
            if (Length == 0)
                return true;
            return false;
        }
    }
}
