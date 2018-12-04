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

        private void PrintListToListTextBox()
        {
            string[] answer = list.FormatAnswer();
            for (int i = 0; i < answer.Length; i++) 
                ListTextBox.Text += (answer[i] + "\r\n");
        }

        private void PrintResultToResultTextBox()
        {
            string[] values = list.FormatAnswer();
            string[] negatives = list.CountNegative();

            for (int i = 0; i < values.Length; i++)
                ResultTextBox.Text += (values[i] + ";   Left: " + negatives[i] + "\r\n");
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
