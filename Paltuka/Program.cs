using Pheltuka.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheltuka
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConsole console = new NewConsole();
            ProgramUI ui = new ProgramUI(console);
            ui.Run();

        }
    }
}
