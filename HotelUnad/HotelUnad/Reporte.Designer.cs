namespace HotelUnad
{
    partial class Reporte
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
            this.labelPayValue = new System.Windows.Forms.Label();
            this.textBoxPayValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPayValue
            // 
            this.labelPayValue.AutoSize = true;
            this.labelPayValue.Location = new System.Drawing.Point(270, 21);
            this.labelPayValue.Name = "labelPayValue";
            this.labelPayValue.Size = new System.Drawing.Size(75, 15);
            this.labelPayValue.TabIndex = 0;
            this.labelPayValue.Text = "Valor a pagar";
            // 
            // textBoxPayValue
            // 
            this.textBoxPayValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPayValue.Location = new System.Drawing.Point(351, 18);
            this.textBoxPayValue.Name = "textBoxPayValue";
            this.textBoxPayValue.ReadOnly = true;
            this.textBoxPayValue.Size = new System.Drawing.Size(142, 23);
            this.textBoxPayValue.TabIndex = 1;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 317);
            this.Controls.Add(this.textBoxPayValue);
            this.Controls.Add(this.labelPayValue);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPayValue;
        private System.Windows.Forms.TextBox textBoxPayValue;
    }
}