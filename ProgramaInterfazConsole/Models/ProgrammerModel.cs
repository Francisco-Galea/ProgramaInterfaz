using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramaInterfazConsole.Interfaces;

namespace ProgramaInterfazConsole.Models
{
    public class ProgrammerModel : IEmployee
    {
        public void DoWork()
        {
            Console.WriteLine("Programando");
        }
    }
}
