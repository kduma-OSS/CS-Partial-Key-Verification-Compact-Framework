using System;
using System.Linq;
using System.Windows.Forms;

namespace KeyGenerator.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            KeyGenerator form;
            if (args.Count() == 1)
                form = new KeyGenerator(args[0]);
            else
                form = new KeyGenerator();


            Application.Run(form);
        }
    }
}
