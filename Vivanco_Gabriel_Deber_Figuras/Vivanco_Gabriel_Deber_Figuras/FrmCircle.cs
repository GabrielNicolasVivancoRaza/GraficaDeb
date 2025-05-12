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
    public partial class FrmCircle : Form
    {
        private ClassCircle ObjCircle = new ClassCircle();
        private FrmCircle()
        {
            InitializeComponent();
        }

        private static FrmCircle instance;

        public static FrmCircle GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmCircle();
            }
            return instance;
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            ObjCircle.initializeData(txtRadius, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjCircle.ReadData(txtRadius);
            ObjCircle.PerimeterCircle();
            ObjCircle.AreaCircle();
            ObjCircle.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCircle.initializeData(txtRadius, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjCircle.CloseForm(this);
        }
    }
}
