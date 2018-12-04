using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MyList
    {
        MyNode head;
        int count;
        int negativeCount;
        /*public MyNode Head
        {
            get { return head; }
            set { head = value; }
        }*/
        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public int NegativeCount
        {
            get { return negativeCount; }
            private set { negativeCount = value; }
        }

        public void Add(double val)
        {
            if (head == null)
                head = new MyNode(val, null);
            else
            {
                MyNode h = head;
                for (int i = 0; i < Count - 1; i++)
                {
                    h = h.Next;
                }
                MyNode p = new MyNode(val, h.Next);
                h.Next = p;
            }
            Count++;
        }

        public MyList()
        {
            this.head = null;
            this.Count = 0;
        }

        public string[] FormatAnswer()
        {

            List<string> ans = new List<string>();
            MyNode h = head;
            for (int i = 0; i < Count; i++)
            {
                ans.Add(h.Val.ToString());
                h = h.Next;
            }

            return ans.ToArray();
        }

        public string[] CountNegative()
        {
            List<string> answer = new List<string>();
            MyNode h = head;

            for (int i = 0; i < Count; i++)
            {
                if (h.Val < 0)
                    NegativeCount++;
                h = h.Next;
            }

            h = head;

            for (int i = 0; i < Count; i++)
            {
                if (h.Val < 0)
                    answer.Add((--NegativeCount).ToString());
                else
                    answer.Add(NegativeCount.ToString());

                h = h.Next;
            }

            return answer.ToArray();
        }
    }
}
