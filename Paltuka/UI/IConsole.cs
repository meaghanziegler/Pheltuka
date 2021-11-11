using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheltuka
{
    public interface IConsole
    {
        ConsoleKeyInfo ReadKey();
        string ReadLine();
        void Clear();
        void Write(string s);
        void WriteLine(string s);
        void WriteLine(object o);

        void Beep(int freq, int duration);
    }
}
