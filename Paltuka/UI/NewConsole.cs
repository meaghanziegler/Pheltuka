using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pheltuka.UI
{
    public class NewConsole : IConsole
    {
        public void Beep(int freq, int duration)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            Console.Beep(432, 200);
            Console.Clear();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string s)
        {
            Console.Write(s);
        }

        public void WriteLine(string s)
        {

            Thread.Sleep(1000);
            Console.Beep(432, 100);
            Console.WriteLine(s);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }
    }
}
