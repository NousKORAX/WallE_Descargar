using ConsoleApp1.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiling
{
    public class RestoreParser : IStatementParser
    {
        public RestoreParser(KeyParser Parser)
        {
            Register(Parser);
        }

        public Declaraciones Parse(KeyParser parser, Token token, List<CompilingError> errors)
        {
            if (!parser.MatchValue(TokenValues.Restore)) return null;
            if (!parser.MatchValue(TokenValues.StatementSeparator))
            {
                errors.Add(new CompilingError(token.Location, ErrorCode.Expected, "Statement separator"));
                return null;
            }
            return new Restore();
        }

        public void Register(KeyParser parser)
        {
            parser.RegisterIStatementParserByValue(TokenValues.Restore, this);
        }
    }
}
