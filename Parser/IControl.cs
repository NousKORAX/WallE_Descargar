using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Parser
{
    public interface IControlParser
    {
        void Register(KeyParser parser);
    }
}
