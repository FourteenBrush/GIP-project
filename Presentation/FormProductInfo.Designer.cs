
namespace Presentation
{
    partial class FormProductInfo
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
            this.labelOmschrijving = new System.Windows.Forms.Label();
            this.textBoxOmschrijving = new System.Windows.Forms.TextBox();
            this.labelprijs = new System.Windows.Forms.Label();
            this.textBoxPrijs = new System.Windows.Forms.TextBox();
            this.buttonOpslaan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelOmschrijving
            // 
            this.labelOmschrijving.AutoSize = true;
            this.labelOmschrijving.Location = new System.Drawing.Point(84, 105);
            this.labelOmschrijving.Name = "labelOmschrijving";
            this.labelOmschrijving.Size = new System.Drawing.Size(98, 20);
            this.labelOmschrijving.TabIndex = 9;
            this.labelOmschrijving.Text = "Omschrijving";
            // 
            // textBoxOmschrijving
            // 
            this.textBoxOmschrijving.Location = new System.Drawing.Point(240, 105);
            this.textBoxOmschrijving.Name = "textBoxOmschrijving";
            this.textBoxOmschrijving.Size = new System.Drawing.Size(271, 26);
            this.textBoxOmschrijving.TabIndex = 10;
            // 
            // labelprijs
            // 
            this.labelprijs.AutoSize = true;
            this.labelprijs.Location = new System.Drawing.Point(84, 166);
            this.labelprijs.Name = "labelprijs";
            this.labelprijs.Size = new System.Drawing.Size(38, 20);
            this.labelprijs.TabIndex = 11;
            this.labelprijs.Text = "Prijs";
            // 
            // textBoxPrijs
            // 
            this.textBoxPrijs.Location = new System.Drawing.Point(240, 166);
            this.textBoxPrijs.Name = "textBoxPrijs";
            this.textBoxPrijs.Size = new System.Drawing.Size(271, 26);
            this.textBoxPrijs.TabIndex = 12;
            // 
            // buttonOpslaan
            // 
            this.buttonOpslaan.Location = new System.Drawing.Point(88, 351);
            this.buttonOpslaan.Name = "buttonOpslaan";
            this.buttonOpslaan.Size = new System.Drawing.Size(112, 34);
            this.buttonOpslaan.TabIndex = 13;
            this.buttonOpslaan.Text = "Opslaan";
            this.buttonOpslaan.UseVisualStyleBackColor = true;
            this.buttonOpslaan.Click += new System.EventHandler(this.buttonOpslaan_Click);
            // 
            // FormProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpslaan);
            this.Controls.Add(this.textBoxPrijs);
            this.Controls.Add(this.labelprijs);
            this.Controls.Add(this.textBoxOmschrijving);
            this.Controls.Add(this.labelOmschrijving);
            this.Name = "FormProductInfo";
            this.Text = "Bewerk product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOmschrijving;
        private System.Windows.Forms.TextBox textBoxOmschrijving;
        private System.Windows.Forms.Label labelprijs;
        private System.Windows.Forms.TextBox textBoxPrijs;
        private System.Windows.Forms.Button buttonOpslaan;
    }
}