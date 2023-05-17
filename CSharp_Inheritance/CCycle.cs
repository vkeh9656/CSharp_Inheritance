using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Inheritance
{
    internal class CCycle : COneCycle
    {
        public Rectangle _rcCircle2;

        public CCycle(string sName) : base(sName)
        {
            strName = sName;
            _Pen = new Pen(Color.Black, 3);

            _rcCircle1 = new Rectangle(30, 150, 120, 120);
            _rcCircle2 = new Rectangle(210, 150, 120, 120);
            _rcSquare1 = new Rectangle(60, 90, 240, 60);
        }


        /// <summary>
        /// 외부에서 호출 가능하도록 사용
        /// </summary>
        /// <param name="iMove"></param>
        public override void Move(int iMove)
        {
            base.Move(iMove);

            Circle2Move(iMove);
        }


        /// <summary>
        ///  내부에서만 변경할 수 있다.
        /// </summary>
        /// <param name="iMove"></param>
        protected void Circle2Move(int iMove)
        {
            Point point = _rcCircle2.Location;
            point.X += iMove;
            _rcCircle2.Location = point;
        }
    }
}
