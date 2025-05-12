using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vivanco_Gabriel_Deber_Figuras
{
    public partial class frmEllipse : Form
    {
        private ClasseEllipse ObjEllipse = new ClasseEllipse();
        public frmEllipse()
        {
            InitializeComponent();
        }
        private static frmEllipse instance;

        public static frmEllipse GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmEllipse();
            }
            return instance;
        }

        private void frmEllipse_Load(object sender, EventArgs e)
        {
            ObjEllipse.initializeData(txtMajor, txtMinor, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjEllipse.ReadData(txtMajor, txtMinor);
            ObjEllipse.PerimeterEllipse();
            ObjEllipse.AreaEllipse();
            ObjEllipse.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjEllipse.initializeData(txtMajor, txtMinor, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjEllipse.CloseForm(this);
        }
    }
}
