using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Compiling
{
    public abstract class UnaryOperatorNode : Expression
    {
        public Expression ToModify;
    }
}