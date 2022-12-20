using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;

namespace CS_330_HamzaJafar
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
         

           
            string[] question_list = System.IO.File.ReadAllLines(@"C:\Users\jafar_hamza\Downloads\quizquestions.txt");

            MessageBox.Show(question_list[2]);

            foreach (string line in question_list)
            {
                Trace.WriteLine(line);
            }

 

        }
    }
}