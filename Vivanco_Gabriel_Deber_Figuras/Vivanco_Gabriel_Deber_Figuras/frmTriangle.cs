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
    public partial class frmTriangle : Form
    {
        private ClassTriangle ObjTriangle = new ClassTriangle();
        private frmTriangle()
        {
            InitializeComponent();
        }

        private static frmTriangle instance;

        public static frmTriangle GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmTriangle();
            }
            return instance;
        }

        private void FrmTriangle_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjTriangle.initializeData(txtBase, txtHeight, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjTriangle.ReadData(txtBase, txtHeight);
            ObjTriangle.PerimeterTriangle();
            ObjTriangle.AreaTriangle();
            ObjTriangle.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjTriangle.initializeData(txtBase, txtHeight, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjTriangle.CloseForm(this);
        }
    }
}
