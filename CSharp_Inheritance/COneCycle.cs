using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inheritance
{
    class COneCycle : CBase
    {
        public Rectangle _rcCircle1;
        public Rectangle _rcSquare1;

        public COneCycle(string sName) 
        {
            strName = sName;
            _Pen = new Pen(Color.WhiteSmoke, 3);

            _rcCircle1 = new Rectangle(120, 150, 120, 120);
            _rcSquare1 = new Rectangle(150, 30, 60, 120);
        }

        public Pen fPenInfo()
        {
            return _Pen;
        }
    }
}
