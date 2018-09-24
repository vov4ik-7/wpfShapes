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
        private int wigth;
        private int height;
        private SolidColorBrush color ;

      public  Shapes()
        {
            this.x0 = x0;
            this.y0 = y0;
            this.wigth = wigth;
            this.height = height;
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
        public int Wigth
        {
            get
            {
                return wigth;
            }
            set
            {
                wigth = value;
            }
        }
        public int Height0
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
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

    }
}
