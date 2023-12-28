using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiling
{
    public abstract class Declaraciones: ASTNode
    {
        abstract public void Execute(ScopeExecution scope, IDrawer drawer, List<Para_Dibujar> para_Dibujar);

    }
}