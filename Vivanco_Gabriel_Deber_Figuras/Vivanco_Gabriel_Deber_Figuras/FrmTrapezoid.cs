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
    public partial class FrmTrapezoid : Form
    {
        private ClassTrapezoid ObjTrapezoid = new ClassTrapezoid();
        public FrmTrapezoid()
        {
            InitializeComponent();
        }
        private static FrmTrapezoid instance;
        public static FrmTrapezoid GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmTrapezoid();
            }
            return instance;
        }
        private void FrmTrapezoid_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjTrapezoid.initializeData(txtMajorBase, txtMinorBase, txtHeight, txtSideOne, txtSideTwo, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjTrapezoid.ReadData(txtMajorBase, txtMinorBase, txtHeight, txtSideOne, txtSideTwo);
            ObjTrapezoid.PerimeterTrapezoid();
            ObjTrapezoid.AreaTrapezoid();
            ObjTrapezoid.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTrapezoid.initializeData(txtMajorBase, txtMinorBase, txtHeight, txtSideOne, txtSideTwo, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjTrapezoid.CloseForm(this);
        }
    }
}
