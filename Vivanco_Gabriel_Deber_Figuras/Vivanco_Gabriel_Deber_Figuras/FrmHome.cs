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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void renderForm(Form form)
        {
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.BringToFront();
            form.Show();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSquare frmCuadrado = FrmSquare.GetInstance();
            renderForm(frmCuadrado);
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRectangle frmRectangulo = frmRectangle.GetInstance();
            renderForm(frmRectangulo);
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCircle frmCirculo = FrmCircle.GetInstance();
            renderForm(frmCirculo);
        }

        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTriangle frmTriangulo = frmTriangle.GetInstance();
            renderForm(frmTriangulo);
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pentágonoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmPentagon frmPentagono = FrmPentagon.GetInstance();
            renderForm(frmPentagono);
        }

        private void hexágonoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmHexagon frmHexagono = FrmHexagon.GetInstance();
            renderForm(frmHexagono);
        }

        private void heptágonoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmHeptagon frmHeptagono = FrmHeptagon.GetInstance();
            renderForm(frmHeptagono);
        }

        private void octágonoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmOctangon frmOctagono = FrmOctangon.GetInstance();
            renderForm(frmOctagono);
        }

        private void eneágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEneagon frmEneagono = FrmEneagon.GetInstance();
            renderForm(frmEneagono);
        }

        private void decágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDecagon frmDecagono = FrmDecagon.GetInstance();
            renderForm(frmDecagono);
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEllipse frmElipse = frmEllipse.GetInstance();
            renderForm(frmElipse);
        }

        private void óvaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOval frmOval = FrmOval.GetInstance();
            renderForm(frmOval);
        }

        private void trapezioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrapezoid frmTrapezio = FrmTrapezoid.GetInstance();
            renderForm(frmTrapezio);
        }

        private void trapezioIsóscelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIsoscelesTrapezoid frmTrapezioIsosceles = FrmIsoscelesTrapezoid.GetInstance();
            renderForm(frmTrapezioIsosceles);
        }

        private void romboideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRombo frmRombo = FrmRombo.GetInstance();
            renderForm(frmRombo);
        }
    }
}
