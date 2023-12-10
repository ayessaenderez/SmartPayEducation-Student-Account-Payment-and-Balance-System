namespace StudentInfoSys.View
{
    partial class UnitCalculator
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
            txtbxAmountPerUnit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtbxUnit = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtbxResult = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // txtbxAmountPerUnit
            // 
            txtbxAmountPerUnit.Location = new Point(270, 102);
            txtbxAmountPerUnit.Name = "txtbxAmountPerUnit";
            txtbxAmountPerUnit.ReadOnly = true;
            txtbxAmountPerUnit.Size = new Size(155, 32);
            txtbxAmountPerUnit.TabIndex = 1;
            txtbxAmountPerUnit.Text = "1500";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(96, 132);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 2;
            label1.Text = "Unit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(270, 137);
            label2.Name = "label2";
            label2.Size = new Size(165, 23);
            label2.TabIndex = 3;
            label2.Text = "Amount Per Unit";
            // 
            // txtbxUnit
            // 
            txtbxUnit.Location = new Point(47, 102);
            txtbxUnit.Name = "txtbxUnit";
            txtbxUnit.Size = new Size(155, 32);
            txtbxUnit.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(224, 106);
            label3.Name = "label3";
            label3.Size = new Size(24, 23);
            label3.TabIndex = 5;
            label3.Text = "X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(136, 186);
            label4.Name = "label4";
            label4.Size = new Size(22, 23);
            label4.TabIndex = 6;
            label4.Text = "=";
            // 
            // txtbxResult
            // 
            txtbxResult.Location = new Point(162, 183);
            txtbxResult.Name = "txtbxResult";
            txtbxResult.Size = new Size(155, 32);
            txtbxResult.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Firebrick;
            btnCalculate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(173, 231);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(124, 41);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // UnitCalculator
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HD_wallpaper_red_and_white_red_aesthetic2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(475, 342);
            Controls.Add(btnCalculate);
            Controls.Add(txtbxResult);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtbxUnit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbxAmountPerUnit);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UnitCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UnitCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxAmountPerUnit;
        private Label label1;
        private Label label2;
        private TextBox txtbxUnit;
        private Label label3;
        private Label label4;
        private TextBox txtbxResult;
        private Button btnCalculate;
    }
}