using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;  
namespace DoAn
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //public static Thread th1;
        //public static Thread th3;
        //public static Thread th5;
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new Form3());
            //Application.Run(new Form5());
            //Application.Run(new Form6());
            //Application.Run(new FormWrong());
            //Application.Run(new FormYesNo());
            //th1 = new Thread(new ThreadStart(openform1));
            //th3 = new Thread(new ThreadStart(openform3));
            //th5 = new Thread(new ThreadStart(openform5));
            //th1.Start();
        }
        //static void openform1()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Form1());
        //}
        //static void openform3()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Form3());
        //}
        //static void openform5()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Form5());
        //}
    }
}
