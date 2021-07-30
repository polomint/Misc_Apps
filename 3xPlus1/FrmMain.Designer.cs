
namespace _3xPlus1
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.nudEnd = new System.Windows.Forms.NumericUpDown();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.rbRange = new System.Windows.Forms.RadioButton();
            this.lbData = new System.Windows.Forms.ListBox();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "End: ";
            // 
            // nudStart
            // 
            this.nudStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudStart.Location = new System.Drawing.Point(53, 12);
            this.nudStart.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(85, 20);
            this.nudStart.TabIndex = 2;
            this.nudStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudEnd
            // 
            this.nudEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudEnd.Location = new System.Drawing.Point(53, 38);
            this.nudEnd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnd.Name = "nudEnd";
            this.nudEnd.Size = new System.Drawing.Size(85, 20);
            this.nudEnd.TabIndex = 3;
            this.nudEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(53, 136);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(85, 23);
            this.BtnCalculate.TabIndex = 4;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Checked = true;
            this.rbSingle.Location = new System.Drawing.Point(53, 90);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(54, 17);
            this.rbSingle.TabIndex = 5;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // rbRange
            // 
            this.rbRange.AutoSize = true;
            this.rbRange.Location = new System.Drawing.Point(53, 113);
            this.rbRange.Name = "rbRange";
            this.rbRange.Size = new System.Drawing.Size(57, 17);
            this.rbRange.TabIndex = 6;
            this.rbRange.Text = "Range";
            this.rbRange.UseVisualStyleBackColor = true;
            // 
            // lbData
            // 
            this.lbData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbData.FormattingEnabled = true;
            this.lbData.Location = new System.Drawing.Point(15, 165);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(124, 470);
            this.lbData.TabIndex = 7;
            // 
            // nudLimit
            // 
            this.nudLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudLimit.Location = new System.Drawing.Point(53, 64);
            this.nudLimit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(85, 20);
            this.nudLimit.TabIndex = 9;
            this.nudLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLimit.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Limit: ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 653);
            this.Controls.Add(this.nudLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.rbRange);
            this.Controls.Add(this.rbSingle);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.nudEnd);
            this.Controls.Add(this.nudStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "3xPlus1";
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.NumericUpDown nudEnd;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbRange;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.Label label3;
    }
}

