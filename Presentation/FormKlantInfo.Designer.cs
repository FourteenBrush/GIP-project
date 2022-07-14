
namespace Presentation
{
    partial class FormKlantInfo
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
            this.textBoxKlantnaam = new System.Windows.Forms.TextBox();
            this.labelKlantnaam = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelTelefoonummer = new System.Windows.Forms.Label();
            this.textBoxTelefoonnummer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxKlantnaam
            // 
            this.textBoxKlantnaam.Location = new System.Drawing.Point(181, 75);
            this.textBoxKlantnaam.Name = "textBoxKlantnaam";
            this.textBoxKlantnaam.Size = new System.Drawing.Size(261, 26);
            this.textBoxKlantnaam.TabIndex = 0;
            // 
            // labelKlantnaam
            // 
            this.labelKlantnaam.AutoSize = true;
            this.labelKlantnaam.Location = new System.Drawing.Point(40, 81);
            this.labelKlantnaam.Name = "labelKlantnaam";
            this.labelKlantnaam.Size = new System.Drawing.Size(51, 20);
            this.labelKlantnaam.TabIndex = 1;
            this.labelKlantnaam.Text = "Naam";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(40, 127);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(51, 20);
            this.labelAdres.TabIndex = 2;
            this.labelAdres.Text = "Adres";
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(181, 124);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(261, 26);
            this.textBoxAdres.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(40, 177);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(181, 177);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(261, 26);
            this.textBoxEmail.TabIndex = 5;
            // 
            // labelTelefoonummer
            // 
            this.labelTelefoonummer.AutoSize = true;
            this.labelTelefoonummer.Location = new System.Drawing.Point(40, 224);
            this.labelTelefoonummer.Name = "labelTelefoonummer";
            this.labelTelefoonummer.Size = new System.Drawing.Size(107, 30);
            this.labelTelefoonummer.TabIndex = 6;
            this.labelTelefoonummer.Text = "Telefoon";
            // 
            // textBoxTelefoonnummer
            // 
            this.textBoxTelefoonnummer.Location = new System.Drawing.Point(181, 224);
            this.textBoxTelefoonnummer.Name = "textBoxTelefoonnummer";
            this.textBoxTelefoonnummer.Size = new System.Drawing.Size(261, 26);
            this.textBoxTelefoonnummer.TabIndex = 7;
            // 
            // FormKlantInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTelefoonnummer);
            this.Controls.Add(this.labelTelefoonummer);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.labelKlantnaam);
            this.Controls.Add(this.textBoxKlantnaam);
            this.Name = "FormKlantInfo";
            this.Text = "Bewerk klant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKlantnaam;
        private System.Windows.Forms.Label labelKlantnaam;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelTelefoonummer;
        private System.Windows.Forms.TextBox textBoxTelefoonnummer;
    }
}