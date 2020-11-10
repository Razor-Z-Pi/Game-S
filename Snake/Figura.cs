using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figura
    {
        protected List<Point> stena;

        public void Sten()
        {
            foreach (Point i in stena)
            {
                i.Draw();
            }
        }
    }
}
