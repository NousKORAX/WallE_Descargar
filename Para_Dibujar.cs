using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compiling;

namespace Compiling
{
    public class Para_Dibujar
    {
        // Propiedades
        public IGeoEntities Pintar { get; set; }
        public string Color { get; set; }
       
        // Constructor
        public Para_Dibujar(IGeoEntities pintar, string color)
        {
            Pintar = pintar;
            Color = color;
           
        }
    }
}