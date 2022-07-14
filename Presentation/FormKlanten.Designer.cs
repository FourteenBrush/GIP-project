
namespace Presentation
{
    partial class FormKlanten
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
            this.listBoxKlanten = new System.Windows.Forms.ListBox();
            this.buttonBewerkKlant = new System.Windows.Forms.Button();
            this.buttonKiesKlant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxKlanten
            // 
            this.listBoxKlanten.FormattingEnabled = true;
            this.listBoxKlanten.ItemHeight = 20;
            this.listBoxKlanten.Location = new System.Drawing.Point(64, 59);
            this.listBoxKlanten.Name = "listBoxKlanten";
            this.listBoxKlanten.Size = new System.Drawing.Size(650, 304);
            this.listBoxKlanten.TabIndex = 0;
            // 
            // buttonBewerkKlant
            // 
            this.buttonBewerkKlant.Location = new System.Drawing.Point(64, 394);
            this.buttonBewerkKlant.Name = "buttonBewerkKlant";
            this.buttonBewerkKlant.Size = new System.Drawing.Size(95, 33);
            this.buttonBewerkKlant.TabIndex = 1;
            this.buttonBewerkKlant.Text = "Bewerk";
            this.buttonBewerkKlant.UseVisualStyleBackColor = true;
            this.buttonBewerkKlant.Click += new System.EventHandler(this.buttonBewerkKlant_Click);
            // 
            // buttonKiesKlant
            // 
            this.buttonKiesKlant.Location = new System.Drawing.Point(196, 394);
            this.buttonKiesKlant.Name = "buttonKiesKlant";
            this.buttonKiesKlant.Size = new System.Drawing.Size(95, 33);
            this.buttonKiesKlant.TabIndex = 2;
            this.buttonKiesKlant.Text = "Selecteer";
            this.buttonKiesKlant.UseVisualStyleBackColor = true;
            this.buttonKiesKlant.Click += new System.EventHandler(this.buttonKiesKlant_Click);
            // 
            // FormKlanten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKiesKlant);
            this.Controls.Add(this.buttonBewerkKlant);
            this.Controls.Add(this.listBoxKlanten);
            this.Name = "FormKlanten";
            this.Text = "Klanten";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKlanten;
        private System.Windows.Forms.Button buttonBewerkKlant;
        private System.Windows.Forms.Button buttonKiesKlant;
    }
}