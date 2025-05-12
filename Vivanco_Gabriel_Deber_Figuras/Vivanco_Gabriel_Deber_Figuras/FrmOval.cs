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
    public partial class FrmOval : Form
    {
        private ClassOval ObjOval = new ClassOval();
        public FrmOval()
        {
            InitializeComponent();
        }

        private static FrmOval instance;

        public static FrmOval GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmOval();
            }
            return instance;
        }

        private void FrmOval_Load(object sender, EventArgs e)
        {
            ObjOval.initializeData(txtRadiusOne, txtRadiusTwo, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjOval.ReadData(txtRadiusOne, txtRadiusTwo);
            ObjOval.PerimeterOval();
            ObjOval.AreaOval();
            ObjOval.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjOval.initializeData(txtRadiusOne, txtRadiusTwo, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjOval.CloseForm(this);
        }
    }
}
