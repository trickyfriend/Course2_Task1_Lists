using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary;

namespace Course2_Task1_Lists
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        static MyList list = new MyList();

        public static MyList ListProperty
        {
            get { return list; }
            set { list = value; }
        }

        static int negativeCount;
        public static int NegativeCount
        {
            get { return negativeCount; }
            set { negativeCount = value; }
        }

        private void PrintListToListTextBox()
        {
            MyNode h = ListProperty.Head;
            for (int i = 0; i < ListProperty.Count; i++)
            {
                if (h.Val < 0)
                    NegativeCount++;
                ListTextBox.Text += ((h.Val) + "\r\n");
                h = h.Next;
            }
        }

        private void PrintResultToResultTextBox()
        {
            MyNode h = ListProperty.Head;
            int negativeLeft = NegativeCount;
            for (int i = 0; i < ListProperty.Count; i++)
            {

                if (h.Val < 0)
                    negativeLeft--;
                ResultTextBox.Text += ((h.Val) + ";   Left: " + negativeLeft + "\r\n");
                h = h.Next;
            }
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    Logic.ReadFile(openFileDialog.FileName, list);
                }
                catch (Exception except)
                {
                    FormsUtils.ErrorMessageBox(except);
                }
            PrintListToListTextBox();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            PrintResultToResultTextBox();
        }
    }
}
