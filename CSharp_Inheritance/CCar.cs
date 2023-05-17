using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inheritance
{
    internal class CCar : CCycle
    {
        public Rectangle _rcSquare2;

        public CCar(string sName) : base(sName)
        {
            strName = sName;
            _Pen = new Pen(Color.Blue, 3);

            _rcCircle1 = new Rectangle(60, 180, 90, 90);
            _rcCircle2 = new Rectangle(210, 180, 90, 90);
            _rcSquare1 = new Rectangle(90, 30, 180, 90);
            _rcSquare2 = new Rectangle(30, 120, 300, 60);
        }

        /// <summary>
        /// 외부에서 호출 가능하도록 사용
        /// </summary>
        /// <param name="iMove"></param>
        public override void Move(int iMove)
        {
            base.Move(iMove);;

            Square2Move(iMove);
        }

        protected void Square2Move(int iMove)
        {
            Point point = _rcSquare2.Location;
            point.X += iMove;
            _rcSquare2.Location = point;
        }
    }
}
