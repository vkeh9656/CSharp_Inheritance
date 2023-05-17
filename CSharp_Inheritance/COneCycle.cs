﻿using System;
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


        /// <summary>
        /// 외부에서 호출 가능하도록 사용
        /// </summary>
        /// <param name="iMove"></param>
        public void Move(int iMove)
        {
            Circle1Move(iMove);
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

        protected void Square1Move(int iMove)
        {
            Point point = _rcSquare1.Location;
            point.X += iMove;
            _rcSquare1.Location = point;
        }
    }
}
