namespace Vivanco_Gabriel_Deber_Figuras
{
    partial class frmEllipse
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
            txtMajor = new TextBox();
            lblMajor = new Label();
            lblMinor = new Label();
            txtMinor = new TextBox();
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
            gbrCanvas.TabIndex = 7;
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
            grbProcess.TabIndex = 6;
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
            grbOutputs.TabIndex = 5;
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
            lblArea.Location = new Point(64, 162);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(49, 20);
            lblArea.TabIndex = 1;
            lblArea.Text = "Área:";
            // 
            // lblPerimeter
            // 
            lblPerimeter.AutoSize = true;
            lblPerimeter.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPerimeter.Location = new Point(29, 86);
            lblPerimeter.Name = "lblPerimeter";
            lblPerimeter.Size = new Size(87, 20);
            lblPerimeter.TabIndex = 0;
            lblPerimeter.Text = "Perímetro:";
            // 
            // grbInputs
            // 
            grbInputs.Controls.Add(txtMinor);
            grbInputs.Controls.Add(lblMinor);
            grbInputs.Controls.Add(txtMajor);
            grbInputs.Controls.Add(lblMajor);
            grbInputs.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbInputs.Location = new Point(12, 27);
            grbInputs.Margin = new Padding(3, 4, 3, 4);
            grbInputs.Name = "grbInputs";
            grbInputs.Padding = new Padding(3, 4, 3, 4);
            grbInputs.Size = new Size(349, 214);
            grbInputs.TabIndex = 4;
            grbInputs.TabStop = false;
            grbInputs.Text = "Entradas";
            // 
            // txtMajor
            // 
            txtMajor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMajor.Location = new Point(133, 61);
            txtMajor.Margin = new Padding(3, 4, 3, 4);
            txtMajor.Name = "txtMajor";
            txtMajor.Size = new Size(182, 30);
            txtMajor.TabIndex = 2;
            // 
            // lblMajor
            // 
            lblMajor.AutoSize = true;
            lblMajor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMajor.Location = new Point(50, 71);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(60, 20);
            lblMajor.TabIndex = 0;
            lblMajor.Text = "Mayor:";
            // 
            // lblMinor
            // 
            lblMinor.AutoSize = true;
            lblMinor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMinor.Location = new Point(57, 131);
            lblMinor.Name = "lblMinor";
            lblMinor.Size = new Size(56, 20);
            lblMinor.TabIndex = 3;
            lblMinor.Text = "Menor";
            // 
            // txtMinor
            // 
            txtMinor.Location = new Point(133, 129);
            txtMinor.Name = "txtMinor";
            txtMinor.Size = new Size(182, 22);
            txtMinor.TabIndex = 4;
            // 
            // frmEllipse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 659);
            Controls.Add(gbrCanvas);
            Controls.Add(grbProcess);
            Controls.Add(grbOutputs);
            Controls.Add(grbInputs);
            Name = "frmEllipse";
            Text = "frmEllipse";
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
        private TextBox txtMinor;
        private Label lblMinor;
        private TextBox txtMajor;
        private Label lblMajor;
    }
}