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
    public partial class FrmHexagon : Form
    {
        private ClassHexagon ObjHexagon = new ClassHexagon();
        public FrmHexagon()
        {
            InitializeComponent();
        }
        private static FrmHexagon instance;
        public static FrmHexagon GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmHexagon();
            }
            return instance;
        }
        private void FrmHexagon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjHexagon.initializeData(txtSide, txtApothem, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            ObjHexagon.ReadData(txtSide, txtApothem);
            ObjHexagon.PerimeterHexagon();
            ObjHexagon.AreaHexagon();
            ObjHexagon.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            ObjHexagon.initializeData(txtSide, txtApothem, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            ObjHexagon.CloseForm(this);
        }
    }
}
