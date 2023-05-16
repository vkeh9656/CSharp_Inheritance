﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void btmOneCycle_Click(object sender, EventArgs e)
        {
            COneCycle cOC = new COneCycle("외발 자전거");
            lblName.Text = cOC.strName;

            Graphics g = pMain.CreateGraphics();

            Pen p = cOC.fPenInfo();
            g.DrawRectangle(p, cOC._rcSquare1);
            g.DrawEllipse(p, cOC._rcCircle1);


            //Pen p = new Pen(Color.Aqua, 2);

            //g.DrawRectangle(p, 50f, 50f, 100f, 150f);
        }
    }
}