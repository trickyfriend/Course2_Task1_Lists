using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



// Дан список вещественных чисел. Для каждого элемента списка напечатать число отрицательных элементов, следующих за ним.



namespace Course2_Task1_Lists
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListForm());
        }
    }
}
