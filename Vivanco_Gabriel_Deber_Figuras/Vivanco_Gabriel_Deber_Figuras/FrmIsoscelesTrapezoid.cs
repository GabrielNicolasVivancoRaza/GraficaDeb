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
    public partial class FrmIsoscelesTrapezoid : Form
    {
        private ClassIsosTrapezoid ObjIsosTrapezoid = new ClassIsosTrapezoid();
        public FrmIsoscelesTrapezoid()
        {
            InitializeComponent();
        }
        private static FrmIsoscelesTrapezoid instance;
        public static FrmIsoscelesTrapezoid GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmIsoscelesTrapezoid();
            }
            return instance;
        }
        private void FrmIsoscelesTrapezoid_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjIsosTrapezoid.initializeData(txtMajorBase, txtMinorBase, txtHeight, txtSide, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjIsosTrapezoid.ReadData(txtMajorBase, txtMinorBase, txtHeight, txtSide);
            ObjIsosTrapezoid.PerimeterIsosTrapezoid();
            ObjIsosTrapezoid.AreaIsosTrapezoid();
            ObjIsosTrapezoid.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjIsosTrapezoid.initializeData(txtMajorBase, txtMinorBase, txtHeight, txtSide, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjIsosTrapezoid.CloseForm(this);
        }
    }
}
