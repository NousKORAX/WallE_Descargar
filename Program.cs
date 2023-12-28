using Compiling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program2
    {
        public static void Main()
        {
            LexicalAnalyzer lexicalAnalyzer = new LexicalAnalyzer();
            List<CompilingError> errors = new List<CompilingError>();
            var a = lexicalAnalyzer.GetTokens("@C:\\Users\\dayan\\Desktop\\Proyecto Final\\WallE Final2\\ConsoleApp1", "point p1; draw p1;", errors);
            var b = new Parser.KeyParser(a);
            Console.WriteLine("xd");
        }
    }
}
