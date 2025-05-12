using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivanco_Gabriel_Deber_Figuras
{
    internal class ClassIsosTrapezoid
    {
        private float mMajorBase;
        private float mMinorBase;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private float mSide;

        public ClassIsosTrapezoid()
        {
            mMajorBase = 0.0f;
            mMinorBase = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            mSide = 0.0f;
        }
        public void ReadData(TextBox txtMajorBase, TextBox txtMinorBase, TextBox txtHeight, TextBox txtSide)
        {
            try
            {
                mMajorBase = float.Parse(txtMajorBase.Text);
                mMinorBase = float.Parse(txtMinorBase.Text);
                mHeight = float.Parse(txtHeight.Text);
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }
        public void PerimeterIsosTrapezoid()
        {
            mPerimeter = mMajorBase + mMinorBase + (2 * mSide);
        }
        public void AreaIsosTrapezoid()
        {
            mArea = ((mMajorBase + mMinorBase) * mHeight) / 2;
        }
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void initializeData(TextBox txtMajorBase, TextBox txtMinorBase, TextBox txtHeight, TextBox txtSide, TextBox txtPerimeter, TextBox txtArea)
        {
            mMajorBase = 0.0f;
            mMinorBase = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            mSide = 0.0f;
            txtMajorBase.Text = "";
            txtMinorBase.Text = "";
            txtHeight.Text = "";
            txtSide.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
        }
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
