using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Compiling
{
    abstract public class BinaryOperatorNode : Expression
    {
        public Expression Left;
        public Expression Right;
    }
}