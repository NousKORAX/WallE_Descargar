﻿using ConsoleApp1.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiling
{
    public class SegmentPrefixParser : IStatementParser
    {
        public SegmentPrefixParser(KeyParser Parser)
        {
            Register(Parser);
        }
        public Declaraciones Parse(KeyParser parser, Token token, List<CompilingError> errors)
        {
            if (!parser.MatchValue(TokenValues.Segment)) return null;


            if (parser.MatchValue(TokenValues.Sequence) && parser.MatchType(TokenType.Identifier))
            {
                if (!parser.MatchValue(TokenValues.StatementSeparator))
                {
                    errors.Add(new CompilingError(token.Location, ErrorCode.Expected, "Statement separator"));
                    return null;
                }
                return new SegmentSequenceInput(token.Location, parser.LookFromIndex(-2).Value);
            }

            if (parser.MatchType(TokenType.Identifier))
            {
                if (!parser.MatchValue(TokenValues.StatementSeparator))
                {
                    errors.Add(new CompilingError(token.Location, ErrorCode.Expected, "Statement separator"));
                    return null;
                }
                return new SegmentInput(token.Location, parser.LookFromIndex(-2).Value);
            }

            return null;
        }

        public void Register(KeyParser parser)
        {
            parser.RegisterIStatementParserByValue(TokenValues.Segment, this);
        }
    }
}
