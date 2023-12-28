using ConsoleApp1.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiling
{
    public interface IStatementParser : IControlParser
    {
        Declaraciones Parse(KeyParser parser, Token token, List<CompilingError> errors);


    }
}

