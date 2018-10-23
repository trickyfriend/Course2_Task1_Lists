using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MyNode
    {
        double val;
        MyNode next;

        public double Val
        {
            get { return val; }
            set { val = value; }
        }
        public MyNode Next
        {
            get { return next; }
            set { next = value; }
        }
        public MyNode(double val, MyNode next)
        {
            this.Val = val;
            this.Next = next;
        }
    }
}
