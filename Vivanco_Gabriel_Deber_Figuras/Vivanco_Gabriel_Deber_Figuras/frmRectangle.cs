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
    public partial class frmRectangle : Form
    {
        // Definición de un objeto de tipo Rectangle.
        private ClassRectangle ObjRectangle = new ClassRectangle();
        private frmRectangle()
        {
            InitializeComponent();
        }

        private static frmRectangle instance;

        public static frmRectangle GetInstance()
        {
            if(instance == null || instance.IsDisposed)
            {
                instance = new frmRectangle();
            }
            return instance;
        }

        private void FrmControl_Load(object sender, EventArgs e)
        {
            // Inicialización de los datos y controles.
            // Llamada a la función InitializeData.
            ObjRectangle.initializeData(txtWidth, txtHeight, txtPerimeter, txtArea);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjRectangle.ReadData(txtWidth, txtHeight);
            ObjRectangle.PerimeterRectangle();
            ObjRectangle.AreaRectangle();
            ObjRectangle.PrintData(txtPerimeter, txtArea);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjRectangle.initializeData(txtWidth, txtHeight, txtPerimeter, txtArea);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjRectangle.CloseForm(this);
        }
    }
}
