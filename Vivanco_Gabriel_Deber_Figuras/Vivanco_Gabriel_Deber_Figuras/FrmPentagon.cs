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
    public partial class FrmPentagon : Form
    {
        private ClassPentagon ObjPentagon = new ClassPentagon();
        public FrmPentagon()
        {
            InitializeComponent();
        }
        private static FrmPentagon instance;
        public static FrmPentagon GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmPentagon();
            }
            return instance;
        }
        private void FrmPentagon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjPentagon.initializeData(txtSide, txtApothem, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjPentagon.ReadData(txtSide, txtApothem);
            ObjPentagon.PerimeterPentagon();
            ObjPentagon.AreaPentagon();
            ObjPentagon.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjPentagon.initializeData(txtSide, txtApothem, txtPerimeter, txtArea);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           ObjPentagon.CloseForm(this);

        }
    }
}
