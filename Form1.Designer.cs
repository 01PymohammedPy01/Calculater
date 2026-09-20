namespace Calculater
{
    partial class frmMainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDigit3 = new System.Windows.Forms.Button();
            this.btnDigit6 = new System.Windows.Forms.Button();
            this.btnDigit9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnDigit2 = new System.Windows.Forms.Button();
            this.btnDigit5 = new System.Windows.Forms.Button();
            this.btnDigit8 = new System.Windows.Forms.Button();
            this.btnDigit0 = new System.Windows.Forms.Button();
            this.btnDigit1 = new System.Windows.Forms.Button();
            this.btnDigit4 = new System.Windows.Forms.Button();
            this.btnDigit7 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtbxResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiply, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSubtract, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDigit3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDigit6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDigit9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button10, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDigit2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDigit5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDigit8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDigit0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnDigit1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDigit4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDigit7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(62, 160);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 351);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 65);
            this.button1.TabIndex = 20;
            this.button1.Tag = "0";
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 64);
            this.button4.TabIndex = 19;
            this.button4.Text = "%";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::Calculater.Properties.Resources.delete_120224;
            this.btnDelete.Location = new System.Drawing.Point(228, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 64);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Image = global::Calculater.Properties.Resources._172503_divide_ve6e594e25d;
            this.btnDivide.Location = new System.Drawing.Point(228, 73);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(71, 64);
            this.btnDivide.TabIndex = 12;
            this.btnDivide.Tag = "4";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.StartCalculate);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(228, 143);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(71, 64);
            this.btnMultiply.TabIndex = 13;
            this.btnMultiply.Tag = "3";
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.StartCalculate);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(228, 213);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(71, 64);
            this.btnSubtract.TabIndex = 14;
            this.btnSubtract.Tag = "2";
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.StartCalculate);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(228, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 65);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Tag = "1";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.StartCalculate);
            // 
            // btnDigit3
            // 
            this.btnDigit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigit3.Location = new System.Drawing.Point(153, 73);
            this.btnDigit3.Name = "btnDigit3";
            this.btnDigit3.Size = new System.Drawing.Size(69, 64);
            this.btnDigit3.TabIndex = 3;
            this.btnDigit3.Tag = "3";
            this.btnDigit3.Text = "3";
            this.btnDigit3.UseVisualStyleBackColor = true;
            this.btnDigit3.Click += new System.EventHandler(this.DigitClick);
            // 
            // btnDigit6
            // 
            this.btnDigit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigit6.Location = new System.Drawing.Point(153, 143);
            this.btnDigit6.Name = "btnDigit6";
            this.btnDigit6.Size = new System.Drawing.Size(69, 64);
            this.btnDigit6.TabIndex = 6;
            this.btnDigit6.Tag = "6";
            this.btnDigit6.Text = "6";
            this.btnDigit6.UseVisualStyleBackColor = true;
            this.btnDigit6.Click += new System.EventHandler(this.DigitClick);
            // 
            // btnDigit9
            // 
            this.btnDigit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigit9.Location = new System.Drawing.Point(153, 213);
            this.btnDigit9.Name = "btnDigit9";
            this.btnDigit9.Size = new System.Drawing.Size(69, 64);
            this.btnDigit9.TabIndex = 9;
            this.btnDigit9.Tag = "9";
            this.btnDigit9.Text = "9";
            this.btnDigit9.UseVisualStyleBackColor = true;
            this.btnDigit9.Click += new System.EventHandler(this.DigitClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(153, 283);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(69, 65);
            this.button10.TabIndex = 11;
            this.button10.Text = ".";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnDigit2
            // 
            this.btnDigit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigit2.Location = new System.Drawing.Point(78, 73);
            this.btnDigit2.Name = "btnDigit2";
            this.btnDigit2.Size = new System.Drawing.Size(69, 64);
            this.btnDigit2.TabIndex = 2;
            this.btnDigit2.Tag = "2";
            this.btnDigit2.Text = "2";
            this.btnDigit2.UseVisualStyleBackColor = true;
            this.btnDigit2.Click += new System.EventHandler(this.DigitClick);
            // 
            // btnDigit5
            // 
            this.btnDigit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigit5.Location = new System.Drawing.Point(78, 143);
            this.btnDigit5.Name = "btnDigit5";
            this.btnDigit5.Size = new System.Drawing.Size(69, 64);
            this.btnDigit5.TabIndex = 5;
            this.btnDigit5.Tag = "5";
            this.btnDigit5.Text = "5";
            this.btnDigit5.UseVisualStyleBackColor = true;
            this.btnDigit5.Click += new System.EventHandler(this.DigitClick);
            // 
            // btnDigit8
            // 
            this.btnDigit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigit8.Location = new System.Drawing.Point(78, 213);
            this.btnDigit8.Name = "btnDigit8";
            this.btnDigit8.Size = new System.Drawing.Size(69, 64);
            this.btnDigit8.TabIndex = 8;
            this.btnDigit8.Tag = "8";
            this.btnDigit8.Text = "8";
            this.btnDigit8.UseVisualStyleBackColor = true;
            this.btnDigit8.Click += new System.EventHandler(this.DigitClick);
            // 
            // btnDigit0
            // 
            this.btnDigit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigit0.Location = new System.Drawing.Point(78, 283);
            this.btnDigit0.Name = "btnDigit0";
            this.btnDigit0.Size = new System.Drawing.Size(69, 65);
            this.btnDigit0.TabIndex = 10;
            this.btnDigit0.Tag = "0";
            this.btnDigit0.Text = "0";
            this.btnDigit0.UseVisualStyleBackColor = true;
            this.btnDigit0.Click += new System.EventHandler(this.DigitClick);
            // 
            // btnDigit1
            // 
            this.btnDigit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigit1.Location = new System.Drawing.Point(3, 73);
            this.btnDigit1.Name = "btnDigit1";
            this.btnDigit1.Size = new System.Drawing.Size(69, 64);
            this.btnDigit1.TabIndex = 1;
            this.btnDigit1.Tag = "1";
            this.btnDigit1.Text = "1";
            this.btnDigit1.UseVisualStyleBackColor = true;
            this.btnDigit1.Click += new System.EventHandler(this.DigitClick);
            // 
            // btnDigit4
            // 
            this.btnDigit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigit4.Location = new System.Drawing.Point(3, 143);
            this.btnDigit4.Name = "btnDigit4";
            this.btnDigit4.Size = new System.Drawing.Size(69, 64);
            this.btnDigit4.TabIndex = 4;
            this.btnDigit4.Tag = "4";
            this.btnDigit4.Text = "4";
            this.btnDigit4.UseVisualStyleBackColor = true;
            this.btnDigit4.Click += new System.EventHandler(this.DigitClick);
            // 
            // btnDigit7
            // 
            this.btnDigit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigit7.Location = new System.Drawing.Point(3, 213);
            this.btnDigit7.Name = "btnDigit7";
            this.btnDigit7.Size = new System.Drawing.Size(69, 64);
            this.btnDigit7.TabIndex = 7;
            this.btnDigit7.Tag = "7";
            this.btnDigit7.Text = "7";
            this.btnDigit7.UseVisualStyleBackColor = true;
            this.btnDigit7.Click += new System.EventHandler(this.DigitClick);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(153, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 64);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(78, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 64);
            this.button3.TabIndex = 18;
            this.button3.Text = "CE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtbxResult
            // 
            this.txtbxResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtbxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxResult.ForeColor = System.Drawing.Color.White;
            this.txtbxResult.Location = new System.Drawing.Point(84, 103);
            this.txtbxResult.MaxLength = 16;
            this.txtbxResult.Name = "txtbxResult";
            this.txtbxResult.Size = new System.Drawing.Size(269, 24);
            this.txtbxResult.TabIndex = 20;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResult.Location = new System.Drawing.Point(80, 66);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(60, 24);
            this.lblResult.TabIndex = 21;
            this.lblResult.Text = "label1";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(430, 543);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtbxResult);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmMainForm";
            this.Text = "Calculater";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDigit9;
        private System.Windows.Forms.Button btnDigit8;
        private System.Windows.Forms.Button btnDigit7;
        private System.Windows.Forms.Button btnDigit6;
        private System.Windows.Forms.Button btnDigit5;
        private System.Windows.Forms.Button btnDigit4;
        private System.Windows.Forms.Button btnDigit2;
        private System.Windows.Forms.Button btnDigit3;
        private System.Windows.Forms.Button btnDigit1;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnDigit0;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtbxResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
    }
}

