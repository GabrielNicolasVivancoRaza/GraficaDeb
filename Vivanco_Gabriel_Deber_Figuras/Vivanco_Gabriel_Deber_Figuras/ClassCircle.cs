using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivanco_Gabriel_Deber_Figuras
{
    internal class ClassCircle
    {
        private float mRadius;
        private float mPerimeter;
        private float mArea;

        public ClassCircle()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterCircle()
        {
            mPerimeter = 2 * (float)Math.PI * mRadius;
        }

        public void AreaCircle()
        {
            mArea = (float)Math.PI * mRadius * mRadius;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void initializeData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea)
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtRadius.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            txtRadius.Focus();
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
