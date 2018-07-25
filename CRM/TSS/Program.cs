using System;

namespace TSS
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            MainForm main_form = new MainForm();

            Presenter presenter = new Presenter(main_form);
            main_form.ShowDialog();
        }
    }
}