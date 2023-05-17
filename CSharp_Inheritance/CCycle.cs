using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inheritance
{
    internal class CCycle : CBase
    {
        public Rectangle _rcCircle1;
        public Rectangle _rcCircle2;
        public Rectangle _rcSquare1;

        public CCycle(string sName)
        {
            strName = sName;
            _Pen = new Pen(Color.Black, 3);

            _rcCircle1 = new Rectangle(30, 150, 120, 120);
            _rcCircle2 = new Rectangle(210, 150, 120, 120);
            _rcSquare1 = new Rectangle(60, 90, 240, 60);
        }

        public Pen fPenInfo()
        {
            return _Pen;
        }



        /// <summary>
        /// 외부에서 호출 가능하도록 사용
        /// </summary>
        /// <param name="iMove"></param>
        public void Move(int iMove)
        {
            Circle1Move(iMove);
            Circle2Move(iMove);
            Square1Move(iMove);
        }


        /// <summary>
        ///  내부에서만 변경할 수 있다.
        /// </summary>
        /// <param name="iMove"></param>
        protected void Circle1Move(int iMove)
        {
            Point point = _rcCircle1.Location;
            point.X += iMove;
            _rcCircle1.Location = point;
        }

        protected void Circle2Move(int iMove)
        {
            Point point = _rcCircle2.Location;
            point.X += iMove;
            _rcCircle2.Location = point;
        }

        protected void Square1Move(int iMove)
        {
            Point point = _rcSquare1.Location;
            point.X += iMove;
            _rcSquare1.Location = point;
        }
    }
}
