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
    public partial class FrmDecagon : Form
    {
        private ClassDecagon ObjDecagon = new ClassDecagon();
        public FrmDecagon()
        {
            InitializeComponent();
        }
        private static FrmDecagon instance;
        public static FrmDecagon GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmDecagon();
            }
            return instance;
        }
        private void FrmDecagon_Load(object sender, EventArgs e)
        {
            ObjDecagon.initializeData(txtSide, txtApothem, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjDecagon.ReadData(txtSide, txtApothem);
            ObjDecagon.PerimeterDecagon();
            ObjDecagon.AreaDecagon();
            ObjDecagon.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjDecagon.initializeData(txtSide, txtApothem, txtPerimeter, txtArea);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            ObjDecagon.CloseForm(this);
        }
    }
}
