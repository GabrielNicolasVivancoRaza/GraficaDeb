using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivanco_Gabriel_Deber_Figuras
{
    internal class ClassSquare
    {
        private float mSide;
        private float mPerimeter;
        private float mArea;

        public ClassSquare()
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterSquare()
        {
            mPerimeter = 4 * mSide;
        }

        public void AreaSquare()
        {
            mArea = mSide * mSide;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void initializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea)
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtSide.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            txtSide.Focus();
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
