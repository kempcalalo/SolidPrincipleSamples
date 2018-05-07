using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.LiskovSubstitutionPrinciple
{
   public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
        public int GetArea()
        {
            return Height * Width;
        }
    }
}
