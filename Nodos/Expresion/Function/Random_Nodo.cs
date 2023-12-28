using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Compiling
{
    public class RandomsConstructorNode : Expression
    {

        public RandomsConstructorNode(CodeLocation location)
        {
            this.Location = location;
        }

        public override bool CheckSemantics(ScopeCheckSemantic scope, List<CompilingError> errors)
        {
            return true;
        }

        public override IGeoEntities EvaluateOn(ScopeExecution scope)
        {
            Random r = new Random(0);
            List<IGeoEntities> toReturn = new List<IGeoEntities>();
            for (int i = 0; i < 50; i++)
            {
                toReturn.Add(new Number(r.Next()));
            }

            return new Sequence(toReturn);

        }
    }
}