namespace ArturPushkov_Assignment12
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.ShiftTxt = new System.Windows.Forms.TextBox();
            this.PayTxt = new System.Windows.Forms.TextBox();
            this.ResultTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shift";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pay";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(86, 25);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 23);
            this.NameTxt.TabIndex = 4;
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(86, 62);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(100, 23);
            this.IdTxt.TabIndex = 5;
            // 
            // ShiftTxt
            // 
            this.ShiftTxt.Location = new System.Drawing.Point(238, 25);
            this.ShiftTxt.Name = "ShiftTxt";
            this.ShiftTxt.Size = new System.Drawing.Size(100, 23);
            this.ShiftTxt.TabIndex = 6;
            // 
            // PayTxt
            // 
            this.PayTxt.Location = new System.Drawing.Point(238, 62);
            this.PayTxt.Name = "PayTxt";
            this.PayTxt.Size = new System.Drawing.Size(100, 23);
            this.PayTxt.TabIndex = 7;
            // 
            // ResultTxt
            // 
            this.ResultTxt.Location = new System.Drawing.Point(29, 118);
            this.ResultTxt.Multiline = true;
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.Size = new System.Drawing.Size(185, 115);
            this.ResultTxt.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 72);
            this.button1.TabIndex = 9;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 245);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultTxt);
            this.Controls.Add(this.PayTxt);
            this.Controls.Add(this.ShiftTxt);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NameTxt;
        private TextBox IdTxt;
        private TextBox ShiftTxt;
        private TextBox PayTxt;
        private TextBox ResultTxt;
        private Button button1;
    }
}