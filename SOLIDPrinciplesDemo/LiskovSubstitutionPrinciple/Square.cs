using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciplesDemo.LiskovSubstitutionPrinciple
{
    /// <summary>
    /// This is a violation of LSP because we can't substitute square to a rectangle without having to change the default behavior of Rectangle
    /// </summary>
    public class Square : Rectangle
    {
        public override int Height
        {
            get => base.Height;
            set => base.Height = base.Width = value;
        }
        public override int Width
        {
            get => base.Width;
            set => base.Height = base.Width = value;
        }
    }
}
