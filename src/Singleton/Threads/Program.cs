namespace ZbW.DesignPatterns.Singleton
{
    using System;

    using ZbW.DesignPatterns.Singleton.Threads;
    using ZbW.DesignPatterns.Singleton.Tpl;

    public class Program
    {
        public static void Main(string[] args)
        {
            TplPrintSpooler.Instance.Start();

            using var numberPrinter = new NumberPrinter();
            using var textPrinter = new TextPrinter();

            Console.ReadLine();
            TplPrintSpooler.Instance.Stop();
            Console.ReadLine();
        }
    }
}
