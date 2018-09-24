using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;



namespace WPFShapes
{
    class Shapes
    {
        private int x0;
        private int y0;
    
        private SolidColorBrush color ;

      public  Shapes()
        {
            this.x0 = x0;
            this.y0 = y0;
           
            this.color = color;
        }
        public int X0
        {
            get
            {
                return x0;
            }
            set
            {
                x0 = value;
            }
        }
        public int Y0
        {
            get
            {
                return y0;
            }
            set
            {
                y0 = value;
            }
        }
       
        public SolidColorBrush Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public double Side(int x, int y)
        {
            return Math.Sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0));
        }

    }
}
