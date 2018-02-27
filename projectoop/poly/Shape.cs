using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectoop.poly
{
    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("drawing");
        }
    }
    public class Circle:Shape
    {
        public sealed override void Draw()
        {
            Console.WriteLine("Circle");
            //base.Draw();
        }
    }
}
