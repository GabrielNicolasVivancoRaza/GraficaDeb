using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivanco_Gabriel_Deber_Figuras
{
    internal class ClassRombo
    {
        private float mHeight;
        private float mSide;
        private float mArea;
        private float mPerimeter;
        private float mMinorDiagonal;
        private float mMajorDiagonal;

        public ClassRombo()
        {
            mHeight = 0.0f;
            mSide = 0.0f;
            mArea = 0.0f;
            mPerimeter = 0.0f;
            mMinorDiagonal = 0.0f;
            mMajorDiagonal = 0.0f;
        }

        public void ReadData(TextBox txtHeight, TextBox txtSide, TextBox txtMinorDiagonal, TextBox txtMajorDiagonal)
        {
            try
            {
                mHeight = float.Parse(txtHeight.Text);
                mSide = float.Parse(txtSide.Text);
                mMinorDiagonal = float.Parse(txtMinorDiagonal.Text);
                mMajorDiagonal = float.Parse(txtMajorDiagonal.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterRombo()
        {
            mPerimeter = 4 * mSide;
        }
        public void AreaRombo()
        {
            mArea = (mMajorDiagonal * mMinorDiagonal) / 2;
        }
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void initializeData(TextBox txtHeight, TextBox txtSide, TextBox txtMinorDiagonal, TextBox txtMajorDiagonal, TextBox txtPerimeter, TextBox txtArea)
        {
            mHeight = 0.0f;
            mSide = 0.0f;
            mArea = 0.0f;
            mPerimeter = 0.0f;
            mMinorDiagonal = 0.0f;
            mMajorDiagonal = 0.0f;
            txtHeight.Text = "";
            txtSide.Text = "";
            txtMinorDiagonal.Text = "";
            txtMajorDiagonal.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtHeight.Focus();
        }
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
