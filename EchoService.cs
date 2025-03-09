using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PseudoRMI_EchoServer
{
    public class EchoService : IEchoService
    {
        public string Echo(string input)
        {
            Console.WriteLine($"Server result: {input}");
            return input;
        }
    }
}
