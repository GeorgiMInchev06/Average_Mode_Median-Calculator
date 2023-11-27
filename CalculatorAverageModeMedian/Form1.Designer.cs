namespace CalculatorAverageModeMedian
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            Average = new Label();
            label1 = new Label();
            label2 = new Label();
            btnCalculate = new Button();
            label3 = new Label();
            txtInput = new TextBox();
            txtAverage = new TextBox();
            txtMode = new TextBox();
            txtMedian = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // Average
            // 
            Average.AutoSize = true;
            Average.BackColor = Color.Transparent;
            Average.Font = new Font("Snap ITC", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            Average.ForeColor = Color.Navy;
            Average.Location = new Point(12, 357);
            Average.Name = "Average";
            Average.Size = new Size(143, 35);
            Average.TabIndex = 0;
            Average.Text = "Average";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Snap ITC", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(12, 407);
            label1.Name = "label1";
            label1.Size = new Size(95, 35);
            label1.TabIndex = 1;
            label1.Text = "Mode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Snap ITC", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(12, 451);
            label2.Name = "label2";
            label2.Size = new Size(125, 35);
            label2.TabIndex = 2;
            label2.Text = "Median";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Yellow;
            btnCalculate.Font = new Font("Snap ITC", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.ForeColor = Color.FromArgb(192, 0, 0);
            btnCalculate.Location = new Point(720, 403);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(278, 91);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Snap ITC", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(259, 35);
            label3.TabIndex = 4;
            label3.Text = "Enter Numbers:";
            // 
            // txtInput
            // 
            txtInput.BackColor = SystemColors.Window;
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Cursor = Cursors.IBeam;
            txtInput.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtInput.Location = new Point(15, 46);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(390, 39);
            txtInput.TabIndex = 5;
            // 
            // txtAverage
            // 
            txtAverage.BackColor = Color.White;
            txtAverage.BorderStyle = BorderStyle.FixedSingle;
            txtAverage.Cursor = Cursors.No;
            txtAverage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAverage.Location = new Point(161, 363);
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(365, 33);
            txtAverage.TabIndex = 6;
            // 
            // txtMode
            // 
            txtMode.BackColor = SystemColors.Window;
            txtMode.BorderStyle = BorderStyle.FixedSingle;
            txtMode.Cursor = Cursors.No;
            txtMode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMode.Location = new Point(161, 409);
            txtMode.Name = "txtMode";
            txtMode.Size = new Size(365, 33);
            txtMode.TabIndex = 7;
            // 
            // txtMedian
            // 
            txtMedian.BackColor = SystemColors.Window;
            txtMedian.BorderStyle = BorderStyle.FixedSingle;
            txtMedian.Cursor = Cursors.No;
            txtMedian.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedian.Location = new Point(161, 453);
            txtMedian.Name = "txtMedian";
            txtMedian.Size = new Size(365, 33);
            txtMedian.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Yellow;
            btnDelete.Font = new Font("Snap ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(593, 437);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 56);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1004, 506);
            Controls.Add(btnDelete);
            Controls.Add(txtMedian);
            Controls.Add(txtMode);
            Controls.Add(txtAverage);
            Controls.Add(txtInput);
            Controls.Add(label3);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Average);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Average;
        private Label label1;
        private Label label2;
        private Button btnCalculate;
        private Label label3;
        private TextBox txtInput;
        private TextBox txtAverage;
        private TextBox txtMode;
        private TextBox txtMedian;
        private Button btnDelete;
    }
}