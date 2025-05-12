using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivanco_Gabriel_Deber_Figuras
{
    internal class ClassTriangle
    {
        private float mBase;
        private float mHeight;
        private float mPerimeter;
        private float mArea;

        public ClassTriangle()
        {
            mBase = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtBase, TextBox txtHeight)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterTriangle()
        {
            mPerimeter = 3 * mBase;
        }

        public void AreaTriangle()
        {
            mArea = (mBase * mHeight) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void initializeData(TextBox txtBase, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea)
        {
            mBase = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtBase.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            txtBase.Focus();
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
