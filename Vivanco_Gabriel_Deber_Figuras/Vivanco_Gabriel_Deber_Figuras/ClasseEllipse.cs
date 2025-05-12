using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vivanco_Gabriel_Deber_Figuras
{
    internal class ClasseEllipse
    {
        private float mSemiMajorAxis;
        private float mSemiMinorAxis;
        private float mPerimeter;
        private float mArea;
        public ClasseEllipse()
        {
            mSemiMajorAxis = 0.0f;
            mSemiMinorAxis = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        public void ReadData(TextBox txtSemiMajorAxis, TextBox txtSemiMinorAxis)
        {
            try
            {
                mSemiMajorAxis = float.Parse(txtSemiMajorAxis.Text);
                mSemiMinorAxis = float.Parse(txtSemiMinorAxis.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }
        public void PerimeterEllipse()
        {
            mPerimeter = (float)(Math.PI * (3 * (mSemiMajorAxis + mSemiMinorAxis) - Math.Sqrt((3 * mSemiMajorAxis + mSemiMinorAxis) * (mSemiMajorAxis + 3 * mSemiMinorAxis))));
        }
        public void AreaEllipse()
        {
            mArea = (float)(Math.PI * mSemiMajorAxis * mSemiMinorAxis);
        }
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void initializeData(TextBox txtSemiMajorAxis, TextBox txtSemiMinorAxis, TextBox txtPerimeter, TextBox txtArea)
        {
            mSemiMajorAxis = 0.0f;
            mSemiMinorAxis = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtSemiMajorAxis.Text = "";
            txtSemiMinorAxis.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            txtSemiMajorAxis.Focus();
        }

        public void CloseForm(Form Objform)
        {
            Objform.Close();
        }
    }
}
