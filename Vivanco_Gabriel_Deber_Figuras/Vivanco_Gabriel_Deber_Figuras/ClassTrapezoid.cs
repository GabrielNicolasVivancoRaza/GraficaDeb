using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivanco_Gabriel_Deber_Figuras
{
    internal class ClassTrapezoid
    {
        private float mMajorBase;
        private float mMinorBase;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private float mSideOne;
        private float mSideTwo;

        public ClassTrapezoid()
        {
            mMajorBase = 0.0f;
            mMinorBase = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            mSideOne = 0.0f;
            mSideTwo = 0.0f;
        }

        public void ReadData(TextBox txtMajorBase, TextBox txtMinorBase, TextBox txtHeight, TextBox txtSideOne, TextBox txtSide2)
        {
            try
            {
                mMajorBase = float.Parse(txtMajorBase.Text);
                mMinorBase = float.Parse(txtMinorBase.Text);
                mHeight = float.Parse(txtHeight.Text);
                mSideOne = float.Parse(txtSideOne.Text);
                mSideTwo = float.Parse(txtSide2.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterTrapezoid()
        {
            mPerimeter = mMajorBase + mMinorBase + mSideOne + mSideTwo;
        }

        public void AreaTrapezoid()
        {
            mArea = ((mMajorBase + mMinorBase) * mHeight) / 2;
        }
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void initializeData(TextBox txtMajorBase, TextBox txtMinorBase, TextBox txtHeight, TextBox txtSide1, TextBox txtSide2, TextBox txtPerimeter, TextBox txtArea)
        {
            mMajorBase = 0.0f;
            mMinorBase = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            mSideOne = 0.0f;
            mSideTwo = 0.0f;
            txtMajorBase.Text = "";
            txtMinorBase.Text = "";
            txtHeight.Text = "";
            txtSide1.Text = "";
            txtSide2.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtMajorBase.Focus();
        }
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
