namespace Dobokocka
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
            this.flowLayoutPanelRolledDiece = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.numericUpDownNumberOfThrows = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfThrows)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelRolledDiece
            // 
            this.flowLayoutPanelRolledDiece.Location = new System.Drawing.Point(12, 262);
            this.flowLayoutPanelRolledDiece.Name = "flowLayoutPanelRolledDiece";
            this.flowLayoutPanelRolledDiece.Size = new System.Drawing.Size(1645, 1186);
            this.flowLayoutPanelRolledDiece.TabIndex = 0;
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(1112, 65);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(179, 107);
            this.buttonRoll.TabIndex = 1;
            this.buttonRoll.Text = "DOBÁS";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // numericUpDownNumberOfThrows
            // 
            this.numericUpDownNumberOfThrows.Location = new System.Drawing.Point(270, 76);
            this.numericUpDownNumberOfThrows.Name = "numericUpDownNumberOfThrows";
            this.numericUpDownNumberOfThrows.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownNumberOfThrows.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hányszor dobjunk?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 1460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownNumberOfThrows);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.flowLayoutPanelRolledDiece);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfThrows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRolledDiece;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfThrows;
        private System.Windows.Forms.Label label1;
    }
}

