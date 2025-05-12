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
    public partial class FrmSquare : Form
    {
        private ClassSquare ObjSquare = new ClassSquare();
        private FrmSquare()
        {
            InitializeComponent();
        }

        private static FrmSquare instance;

        public static FrmSquare GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmSquare();
            }
            return instance;
        }

        private void FrmSquare_Load(object sender, EventArgs e)
        {
            ObjSquare.initializeData(txtSide, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjSquare.ReadData(txtSide);
            ObjSquare.PerimeterSquare();
            ObjSquare.AreaSquare();
            ObjSquare.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjSquare.initializeData(txtSide, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjSquare.CloseForm(this);
        }
    }
}
