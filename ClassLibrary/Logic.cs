using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public static class Logic
    {
        public static void ReadFile(string filename, MyList list)
        {
            using ( StreamReader sr = new StreamReader(filename) )
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(Convert.ToDouble(line));
                }
            }
        }
    }
}
