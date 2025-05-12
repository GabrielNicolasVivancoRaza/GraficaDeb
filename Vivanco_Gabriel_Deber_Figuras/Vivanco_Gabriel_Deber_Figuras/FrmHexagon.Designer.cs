namespace Vivanco_Gabriel_Deber_Figuras
{
    partial class FrmHexagon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbrCanvas = new GroupBox();
            picCanvas = new PictureBox();
            grbProcess = new GroupBox();
            btnExit = new Button();
            btnReset = new Button();
            btnCalculate = new Button();
            grbOutputs = new GroupBox();
            txtArea = new TextBox();
            txtPerimeter = new TextBox();
            lblArea = new Label();
            lblPerimeter = new Label();
            grbInputs = new GroupBox();
            txtApothem = new TextBox();
            txtSide = new TextBox();
            lblApothem = new Label();
            lblSide = new Label();
            gbrCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            grbProcess.SuspendLayout();
            grbOutputs.SuspendLayout();
            grbInputs.SuspendLayout();
            SuspendLayout();
            // 
            // gbrCanvas
            // 
            gbrCanvas.Controls.Add(picCanvas);
            gbrCanvas.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbrCanvas.Location = new Point(391, 27);
            gbrCanvas.Margin = new Padding(3, 4, 3, 4);
            gbrCanvas.Name = "gbrCanvas";
            gbrCanvas.Padding = new Padding(3, 4, 3, 4);
            gbrCanvas.Size = new Size(724, 605);
            gbrCanvas.TabIndex = 15;
            gbrCanvas.TabStop = false;
            gbrCanvas.Text = "Gráfico";
            // 
            // picCanvas
            // 
            picCanvas.Location = new Point(7, 28);
            picCanvas.Margin = new Padding(3, 4, 3, 4);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(711, 570);
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            // 
            // grbProcess
            // 
            grbProcess.Controls.Add(btnExit);
            grbProcess.Controls.Add(btnReset);
            grbProcess.Controls.Add(btnCalculate);
            grbProcess.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbProcess.Location = new Point(13, 268);
            grbProcess.Margin = new Padding(3, 4, 3, 4);
            grbProcess.Name = "grbProcess";
            grbProcess.Padding = new Padding(3, 4, 3, 4);
            grbProcess.Size = new Size(348, 101);
            grbProcess.TabIndex = 14;
            grbProcess.TabStop = false;
            grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(240, 39);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 41);
            btnExit.TabIndex = 2;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(120, 39);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(89, 41);
            btnReset.TabIndex = 1;
            btnReset.Text = "Resetear";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(15, 39);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(84, 41);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // grbOutputs
            // 
            grbOutputs.Controls.Add(txtArea);
            grbOutputs.Controls.Add(txtPerimeter);
            grbOutputs.Controls.Add(lblArea);
            grbOutputs.Controls.Add(lblPerimeter);
            grbOutputs.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbOutputs.Location = new Point(13, 397);
            grbOutputs.Margin = new Padding(3, 4, 3, 4);
            grbOutputs.Name = "grbOutputs";
            grbOutputs.Padding = new Padding(3, 4, 3, 4);
            grbOutputs.Size = new Size(348, 235);
            grbOutputs.TabIndex = 13;
            grbOutputs.TabStop = false;
            grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            txtArea.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArea.Location = new Point(132, 149);
            txtArea.Margin = new Padding(3, 4, 3, 4);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(182, 30);
            txtArea.TabIndex = 5;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPerimeter.Location = new Point(132, 76);
            txtPerimeter.Margin = new Padding(3, 4, 3, 4);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.ReadOnly = true;
            txtPerimeter.Size = new Size(182, 30);
            txtPerimeter.TabIndex = 4;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(64, 164);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(49, 20);
            lblArea.TabIndex = 1;
            lblArea.Text = "Área:";
            // 
            // lblPerimeter
            // 
            lblPerimeter.AutoSize = true;
            lblPerimeter.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPerimeter.Location = new Point(29, 88);
            lblPerimeter.Name = "lblPerimeter";
            lblPerimeter.Size = new Size(87, 20);
            lblPerimeter.TabIndex = 0;
            lblPerimeter.Text = "Perímetro:";
            // 
            // grbInputs
            // 
            grbInputs.Controls.Add(txtApothem);
            grbInputs.Controls.Add(txtSide);
            grbInputs.Controls.Add(lblApothem);
            grbInputs.Controls.Add(lblSide);
            grbInputs.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbInputs.Location = new Point(12, 27);
            grbInputs.Margin = new Padding(3, 4, 3, 4);
            grbInputs.Name = "grbInputs";
            grbInputs.Padding = new Padding(3, 4, 3, 4);
            grbInputs.Size = new Size(349, 214);
            grbInputs.TabIndex = 12;
            grbInputs.TabStop = false;
            grbInputs.Text = "Entradas";
            // 
            // txtApothem
            // 
            txtApothem.Location = new Point(130, 99);
            txtApothem.Name = "txtApothem";
            txtApothem.Size = new Size(185, 22);
            txtApothem.TabIndex = 7;
            // 
            // txtSide
            // 
            txtSide.Location = new Point(130, 65);
            txtSide.Name = "txtSide";
            txtSide.Size = new Size(185, 22);
            txtSide.TabIndex = 6;
            // 
            // lblApothem
            // 
            lblApothem.AutoSize = true;
            lblApothem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApothem.Location = new Point(34, 102);
            lblApothem.Name = "lblApothem";
            lblApothem.Size = new Size(80, 20);
            lblApothem.TabIndex = 4;
            lblApothem.Text = "Apotema:";
            // 
            // lblSide
            // 
            lblSide.AutoSize = true;
            lblSide.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSide.Location = new Point(63, 66);
            lblSide.Name = "lblSide";
            lblSide.Size = new Size(51, 20);
            lblSide.TabIndex = 3;
            lblSide.Text = "Lado:";
            // 
            // FrmHexagon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 659);
            Controls.Add(gbrCanvas);
            Controls.Add(grbProcess);
            Controls.Add(grbOutputs);
            Controls.Add(grbInputs);
            Name = "FrmHexagon";
            Text = "FrmHexagon";
            gbrCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            grbProcess.ResumeLayout(false);
            grbOutputs.ResumeLayout(false);
            grbOutputs.PerformLayout();
            grbInputs.ResumeLayout(false);
            grbInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbrCanvas;
        private PictureBox picCanvas;
        private GroupBox grbProcess;
        private Button btnExit;
        private Button btnReset;
        private Button btnCalculate;
        private GroupBox grbOutputs;
        private TextBox txtArea;
        private TextBox txtPerimeter;
        private Label lblArea;
        private Label lblPerimeter;
        private GroupBox grbInputs;
        private TextBox txtApothem;
        private TextBox txtSide;
        private Label lblApothem;
        private Label lblSide;
    }
}