using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compiling;

namespace ConsoleApp1.Nodos
{
    public class Program : ASTNode
    {
        public Program(List<Declaraciones> Statements)
        {
            this.Statements = Statements;
        }
        public List<Declaraciones> Statements { get; set; }
        public override bool CheckSemantics(ScopeCheckSemantic scope, List<CompilingError> errors)
        {

            foreach (Declaraciones Declaraciones in Statements)
            {
                if (!Declaraciones.CheckSemantics(scope, errors)) return false;
            }
            return true;
        }

        public void Run(ScopeExecution scope, IDrawer drawer, List<Para_Dibujar> para_Dibujars)
        {
            int initial = scope.Errors.Count;
            foreach (var item in Statements)
            {
                item.Execute(scope, drawer, para_Dibujars);
                if (scope.Errors.Count != initial)
                    break;

            }
        }
    }
}
