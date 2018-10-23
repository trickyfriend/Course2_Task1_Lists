using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MyList
    {
        MyNode head;
        int count;

        public MyNode Head
        {
            get { return head; }
            set { head = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public void Add(double val)
        {
            if (head == null)
                head = new MyNode(val, null);
            else
            {
                MyNode h = Head;
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
            this.Head = null;
            this.Count = 0;
        }
    }
}
