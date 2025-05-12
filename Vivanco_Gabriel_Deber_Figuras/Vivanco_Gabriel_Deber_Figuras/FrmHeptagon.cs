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
    public partial class FrmHeptagon : Form
    {
        private ClassHeptagon ObjHeptagon = new ClassHeptagon();
        public FrmHeptagon()
        {
            InitializeComponent();
        }
        private static FrmHeptagon instance;

        public static FrmHeptagon GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmHeptagon();
            }
            return instance;
        }
        private void FrmHeptagon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjHeptagon.initializeData(txtSide, txtApothem, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            ObjHeptagon.ReadData(txtSide, txtApothem);
            ObjHeptagon.PerimeterHeptagon();
            ObjHeptagon.AreaHeptagon();
            ObjHeptagon.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            ObjHeptagon.initializeData(txtSide, txtApothem, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            ObjHeptagon.CloseForm(this);
        }
    }
}
