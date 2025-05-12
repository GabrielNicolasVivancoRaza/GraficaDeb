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
    public partial class FrmRombo : Form
    {
        private ClassRombo ObjRombo = new ClassRombo();
        public FrmRombo()
        {
            InitializeComponent();
        }

        private static FrmRombo instance;
        public static FrmRombo GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmRombo();
            }
            return instance;
        }
        private void FrmRombo_Load(object sender, EventArgs e)
        {
            ObjRombo.initializeData(txtHeight, txtSide, txtMinorDiagonal, txtMajorDiagonal, txtPerimeter, txtArea);
        }

        private void txtMajorBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjRombo.ReadData(txtHeight, txtSide, txtMinorDiagonal, txtMajorDiagonal);
            ObjRombo.PerimeterRombo();
            ObjRombo.AreaRombo();
            ObjRombo.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            ObjRombo.initializeData(txtHeight, txtSide, txtMinorDiagonal, txtMajorDiagonal, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjRombo.CloseForm(this);

        }
    }
}
