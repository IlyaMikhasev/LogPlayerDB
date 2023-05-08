namespace LogPlayerDB
{
    partial class Form1
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
            this.LName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butEnter = new System.Windows.Forms.Button();
            this.l_output = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(42, 32);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(35, 13);
            this.LName.TabIndex = 0;
            this.LName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Age";
            this.label1.UseWaitCursor = true;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(94, 32);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 3;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(94, 67);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(100, 20);
            this.AgeBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите имя и возраст персонажа";
            // 
            // butEnter
            // 
            this.butEnter.Location = new System.Drawing.Point(94, 93);
            this.butEnter.Name = "butEnter";
            this.butEnter.Size = new System.Drawing.Size(75, 23);
            this.butEnter.TabIndex = 6;
            this.butEnter.Text = "Ввод";
            this.butEnter.UseVisualStyleBackColor = true;
            this.butEnter.Click += new System.EventHandler(this.butEnter_Click);
            // 
            // l_output
            // 
            this.l_output.AutoSize = true;
            this.l_output.Location = new System.Drawing.Point(13, 144);
            this.l_output.Name = "l_output";
            this.l_output.Size = new System.Drawing.Size(37, 13);
            this.l_output.TabIndex = 7;
            this.l_output.Text = "output";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(94, 326);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 8;
            this.bDelete.Text = "Clear";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.l_output);
            this.Controls.Add(this.butEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butEnter;
        private System.Windows.Forms.Label l_output;
        private System.Windows.Forms.Button bDelete;
    }
}

