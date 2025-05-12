using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivanco_Gabriel_Deber_Figuras
{
    internal class ClassOval
    {
        private float mRadiusOne;
        private float mRadiusTwo;
        private float mPerimeter;
        private float mArea;

        public ClassOval()
        {
            mRadiusOne = 0.0f;
            mRadiusTwo = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadiusOne, TextBox txtRadiusTwo)
        {
            try
            {
                mRadiusOne = float.Parse(txtRadiusOne.Text);
                mRadiusTwo = float.Parse(txtRadiusTwo.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void AreaOval()
        {
            mArea = (float)Math.PI * mRadiusOne * mRadiusTwo;
        }

        public void PerimeterOval()
        {
            mPerimeter = (float)Math.PI * (3 * (mRadiusOne + mRadiusTwo) - (float)Math.Sqrt((3 * mRadiusOne + mRadiusTwo) * (mRadiusOne + 3 * mRadiusTwo)));
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void initializeData(TextBox txtRadiusOne, TextBox txtRadiusTwo, TextBox txtPerimeter, TextBox txtArea)
        {
            mRadiusOne = 0.0f;
            mRadiusTwo = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtRadiusOne.Text = "";
            txtRadiusTwo.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtRadiusOne.Focus();
        }
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }
}
