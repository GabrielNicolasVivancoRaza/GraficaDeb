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
    public partial class FrmEneagon : Form
    {
        private ClassEneagon ObjEneagon = new ClassEneagon();
        public FrmEneagon()
        {
            InitializeComponent();
        }

        private static FrmEneagon instance;
        public static FrmEneagon GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmEneagon();
            }
            return instance;
        }
        private void FrmEneagon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjEneagon.initializeData(txtSide, txtApothem, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            ObjEneagon.ReadData(txtSide, txtApothem);
            ObjEneagon.PerimeterEneagon();
            ObjEneagon.AreaEneagon();
            ObjEneagon.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            ObjEneagon.initializeData(txtSide, txtApothem, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            ObjEneagon.CloseForm(this);
        }
    }
}
