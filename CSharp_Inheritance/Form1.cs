using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Inheritance
{
    public partial class Form1 : Form
    {
        COneCycle _cOC;
        CCycle _cC;
        CCar _cCar;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발 자전거");
            _cC = new CCycle("자전거");
            _cCar = new CCar("자동차");
        }


        private void btmOneCycle_Click(object sender, EventArgs e)
        {
            ClearPanel();
            OneCycleDraw();
        }

        /// <summary>
        /// OneCycle에 대한 위치 그림을 그려준다.
        /// </summary>
        private void OneCycleDraw()
        {
            lblName.Text = _cOC.strName;

            Graphics g = pMain.CreateGraphics();

            Pen p = _cOC.fPenInfo(Color.DarkKhaki, 10);
            g.DrawRectangle(p, _cOC._rcSquare1);
            g.DrawEllipse(p, _cOC._rcCircle1);
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CycleDraw();
        }

        /// <summary>
        /// Cycle에 대한 위치 그림을 그려준다.
        /// </summary
        private void CycleDraw()
        {
            lblName.Text = _cC.strName;

            Graphics g = pMain.CreateGraphics();

            Pen p = _cC.fPenInfo(Color.Beige, 5);
            g.DrawRectangle(p, _cC._rcSquare1);
            g.DrawEllipse(p, _cC._rcCircle1);
            g.DrawEllipse(p, _cC._rcCircle2);
        }


        private void btnCar_Click(object sender, EventArgs e)
        {
            ClearPanel();
            CarDraw();
        }

        private void CarDraw()
        {
            lblName.Text = _cCar.strName;

            Graphics g = pMain.CreateGraphics();

            Pen p = _cCar.fPenInfo(Color.BurlyWood, 2);
            g.DrawRectangle(p, _cCar._rcSquare1);
            g.DrawRectangle(p, _cCar._rcSquare2);
            g.DrawEllipse(p, _cCar._rcCircle1);
            g.DrawEllipse(p, _cCar._rcCircle2);
        }


        private void ClearPanel()
        {
            pMain.Invalidate();
            Refresh();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            ClearPanel();

            Moving(-10);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ClearPanel();

            Moving(10);
        }

        private void Form1_KeyDown1(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.A)
            {
                Moving(-10);
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.D)
            {
                Moving(10);
            }
        }

        private void Moving(int iMove)
        {
            ClearPanel();

            switch (lblName.Text)
            {
                case "외발 자전거":
                    _cOC.Move(iMove);
                    OneCycleDraw();
                    break;
                case "자전거":
                    _cC.Move(iMove);
                    CycleDraw();
                    break;
                case "자동차":
                    _cCar.Move(iMove);
                    CarDraw();
                    break;
                default:
                    break;
            }
        }
    }
}