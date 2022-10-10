namespace Dobokocka
{
    partial class UserControlRolledDice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxDiece = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRolledDiceValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiece)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDiece
            // 
            this.pictureBoxDiece.Image = global::Dobokocka.Properties.Resources.dice_1;
            this.pictureBoxDiece.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxDiece.Name = "pictureBoxDiece";
            this.pictureBoxDiece.Size = new System.Drawing.Size(332, 335);
            this.pictureBoxDiece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDiece.TabIndex = 0;
            this.pictureBoxDiece.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "A dobott szám:";
            // 
            // labelRolledDiceValue
            // 
            this.labelRolledDiceValue.AutoSize = true;
            this.labelRolledDiceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRolledDiceValue.Location = new System.Drawing.Point(3, 414);
            this.labelRolledDiceValue.Name = "labelRolledDiceValue";
            this.labelRolledDiceValue.Size = new System.Drawing.Size(52, 55);
            this.labelRolledDiceValue.TabIndex = 2;
            this.labelRolledDiceValue.Text = "0";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRolledDiceValue, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxDiece, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.08064F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.91935F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 544);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // UserControlRolledDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControlRolledDice";
            this.Size = new System.Drawing.Size(340, 549);
            this.Load += new System.EventHandler(this.UserControlRolledDice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiece)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDiece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRolledDiceValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
