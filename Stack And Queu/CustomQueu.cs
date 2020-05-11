using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_And_Queu
{
    public class CustomQueu : CustomStack
    {
        private Node tail;
        public CustomQueu(): base(){
            tail = null;
        }

        public void EnQueu(int x)
        {
            Node p = new Node(x);
            if (head  == null)
                head = tail = null;
            else
            {
                tail.Next = p;
                tail = p;
            }
            Length++;

        }

        public int DeQueu()
        {
            int result = head.Value;
            head = head.Next;
            Length--;
            return result;
        }
    }
}
