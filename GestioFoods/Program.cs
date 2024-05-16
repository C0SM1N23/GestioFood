namespace Desktop_App_.NET_8._0
{
    internal static class Program
    {

        [STAThread]
        static void Main()
       {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}