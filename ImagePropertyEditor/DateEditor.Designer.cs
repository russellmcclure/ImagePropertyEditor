using System;
using System.ComponentModel;
using System.Drawing;

namespace ImagePropertyEditor
{
    partial class DateEditor
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
        
        //[Description("Test text displayed in the textbox"), Category("Data")]
        //public string RussmanFTW
        //{
        //    get => this.label1.Text;
        //    set => this.label1.Text = value;
        //}
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(30, 3);
            this.yearTextBox.MaxLength = 4;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(52, 30);
            this.yearTextBox.TabIndex = 1;
            this.yearTextBox.Text = "0000";
            this.yearTextBox.TextChanged += new System.EventHandler(this.yearTextBox_TextChanged);
            this.yearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Y:";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(118, 3);
            this.monthTextBox.MaxLength = 2;
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(30, 30);
            this.monthTextBox.TabIndex = 3;
            this.monthTextBox.TextChanged += new System.EventHandler(this.monthTextBox_TextChanged);
            this.monthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "M:";
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(182, 3);
            this.dayTextBox.MaxLength = 2;
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(30, 30);
            this.dayTextBox.TabIndex = 5;
            this.dayTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "D:";
            // 
            // DateEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DateEditor";
            this.Size = new System.Drawing.Size(226, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.Label label3;
    }
}
