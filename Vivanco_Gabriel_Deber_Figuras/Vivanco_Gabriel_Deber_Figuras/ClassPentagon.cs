using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivanco_Gabriel_Deber_Figuras
{
    internal class ClassPentagon
    {
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private float mApothem;

        public ClassPentagon()
        {
            mSide = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            mApothem = 0.0f;
        }

        public void ReadData(TextBox txtSide, TextBox txtApothem)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
                mApothem = float.Parse(txtApothem.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterPentagon()
        {
            mPerimeter = 5 * mSide;
        }
        public void AreaPentagon()
        {
            mArea = (mPerimeter * mApothem) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void initializeData(TextBox txtSide, TextBox txtApothem, TextBox txtPerimeter, TextBox txtArea)
        {
            mSide = 0.0f;
            mApothem = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtSide.Text = "";
            txtApothem.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSide.Focus();
        }
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
