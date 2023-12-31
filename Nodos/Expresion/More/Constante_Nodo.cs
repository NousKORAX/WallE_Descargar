﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Compiling
{
    public class ConstantNode : Expression
    {
        public double Value { get; private set; }

        public ConstantNode(CodeLocation location, double Value)
        {
            this.Value = Value;
            this.Location = location;
        }
        public override bool CheckSemantics(ScopeCheckSemantic scope, List<CompilingError> errors)
        {
            return true;
        }

        public override IGeoEntities EvaluateOn(ScopeExecution scope)
        {
            return new Number(Value);
        }
    }
}
