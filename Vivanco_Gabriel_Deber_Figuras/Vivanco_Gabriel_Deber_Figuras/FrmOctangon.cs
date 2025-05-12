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
    public partial class FrmOctangon : Form
    {
        private ClassOctagon ObjOctagon = new ClassOctagon();
        public FrmOctangon()
        {
            InitializeComponent();
        }
        private static FrmOctangon instance;
        public static FrmOctangon GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmOctangon();
            }
            return instance;
        }
        private void FrmOctangon_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjOctagon.initializeData(txtSide, txtApothem, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            ObjOctagon.ReadData(txtSide, txtApothem);
            ObjOctagon.PerimeterOctagon();
            ObjOctagon.AreaOctagon();
            ObjOctagon.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            ObjOctagon.initializeData(txtSide, txtApothem, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            ObjOctagon.CloseForm(this);
        }
    }
}
