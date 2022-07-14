
namespace Presentation
{
    partial class FormFactuur
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
            this.listBoxProducten = new System.Windows.Forms.ListBox();
            this.listBoxBestellingen = new System.Windows.Forms.ListBox();
            this.buttonBestellingToevoegen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelKlantInfo = new System.Windows.Forms.Label();
            this.buttonKiesKlant = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPrijs = new System.Windows.Forms.Label();
            this.buttonBestellingVerwijderen = new System.Windows.Forms.Button();
            this.buttonBewerkProduct = new System.Windows.Forms.Button();
            this.labelKlant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxProducten
            // 
            this.listBoxProducten.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxProducten.FormattingEnabled = true;
            this.listBoxProducten.ItemHeight = 20;
            this.listBoxProducten.Location = new System.Drawing.Point(26, 54);
            this.listBoxProducten.Name = "listBoxProducten";
            this.listBoxProducten.Size = new System.Drawing.Size(309, 184);
            this.listBoxProducten.TabIndex = 0;
            // 
            // listBoxBestellingen
            // 
            this.listBoxBestellingen.FormattingEnabled = true;
            this.listBoxBestellingen.ItemHeight = 20;
            this.listBoxBestellingen.Location = new System.Drawing.Point(458, 54);
            this.listBoxBestellingen.Name = "listBoxBestellingen";
            this.listBoxBestellingen.Size = new System.Drawing.Size(309, 184);
            this.listBoxBestellingen.TabIndex = 1;
            // 
            // buttonBestellingToevoegen
            // 
            this.buttonBestellingToevoegen.Location = new System.Drawing.Point(357, 103);
            this.buttonBestellingToevoegen.Name = "buttonBestellingToevoegen";
            this.buttonBestellingToevoegen.Size = new System.Drawing.Size(75, 34);
            this.buttonBestellingToevoegen.TabIndex = 2;
            this.buttonBestellingToevoegen.Text = ">>>";
            this.buttonBestellingToevoegen.UseVisualStyleBackColor = true;
            this.buttonBestellingToevoegen.Click += new System.EventHandler(this.buttonBestellingToevoegen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bestellingen";
            // 
            // labelKlantInfo
            // 
            this.labelKlantInfo.AutoSize = true;
            this.labelKlantInfo.Location = new System.Drawing.Point(158, 298);
            this.labelKlantInfo.Name = "labelKlantInfo";
            this.labelKlantInfo.Size = new System.Drawing.Size(9, 40);
            this.labelKlantInfo.TabIndex = 5;
            this.labelKlantInfo.Text = "\r\n\r\n";
            // 
            // buttonKiesKlant
            // 
            this.buttonKiesKlant.Location = new System.Drawing.Point(26, 339);
            this.buttonKiesKlant.Name = "buttonKiesKlant";
            this.buttonKiesKlant.Size = new System.Drawing.Size(112, 34);
            this.buttonKiesKlant.TabIndex = 6;
            this.buttonKiesKlant.Text = "Kies klant";
            this.buttonKiesKlant.UseVisualStyleBackColor = true;
            this.buttonKiesKlant.Click += new System.EventHandler(this.buttonKiesKlant_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prijs";
            // 
            // labelPrijs
            // 
            this.labelPrijs.AutoSize = true;
            this.labelPrijs.Location = new System.Drawing.Point(535, 298);
            this.labelPrijs.Name = "labelPrijs";
            this.labelPrijs.Size = new System.Drawing.Size(49, 20);
            this.labelPrijs.TabIndex = 8;
            this.labelPrijs.Text = "€0.00";
            // 
            // buttonBestellingVerwijderen
            // 
            this.buttonBestellingVerwijderen.Location = new System.Drawing.Point(357, 155);
            this.buttonBestellingVerwijderen.Name = "buttonBestellingVerwijderen";
            this.buttonBestellingVerwijderen.Size = new System.Drawing.Size(75, 34);
            this.buttonBestellingVerwijderen.TabIndex = 9;
            this.buttonBestellingVerwijderen.Text = "<<<";
            this.buttonBestellingVerwijderen.UseVisualStyleBackColor = true;
            this.buttonBestellingVerwijderen.Click += new System.EventHandler(this.buttonBestellingVerwijderen_Click);
            // 
            // buttonBewerkProduct
            // 
            this.buttonBewerkProduct.Location = new System.Drawing.Point(26, 264);
            this.buttonBewerkProduct.Name = "buttonBewerkProduct";
            this.buttonBewerkProduct.Size = new System.Drawing.Size(112, 34);
            this.buttonBewerkProduct.TabIndex = 10;
            this.buttonBewerkProduct.Text = "Bewerk";
            this.buttonBewerkProduct.UseVisualStyleBackColor = true;
            this.buttonBewerkProduct.Click += new System.EventHandler(this.buttonBewerkProduct_Click);
            // 
            // labelKlant
            // 
            this.labelKlant.AutoSize = true;
            this.labelKlant.Location = new System.Drawing.Point(179, 346);
            this.labelKlant.Name = "labelKlant";
            this.labelKlant.Size = new System.Drawing.Size(0, 30);
            this.labelKlant.TabIndex = 11;
            // 
            // FormFactuur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 385);
            this.Controls.Add(this.labelKlant);
            this.Controls.Add(this.buttonBewerkProduct);
            this.Controls.Add(this.buttonBestellingVerwijderen);
            this.Controls.Add(this.labelPrijs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonKiesKlant);
            this.Controls.Add(this.labelKlantInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBestellingToevoegen);
            this.Controls.Add(this.listBoxBestellingen);
            this.Controls.Add(this.listBoxProducten);
            this.Name = "FormFactuur";
            this.Text = "Nieuwe factuur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducten;
        private System.Windows.Forms.ListBox listBoxBestellingen;
        private System.Windows.Forms.Button buttonBestellingToevoegen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKlantInfo;
        private System.Windows.Forms.Button buttonKiesKlant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPrijs;
        private System.Windows.Forms.Button buttonBestellingVerwijderen;
        private System.Windows.Forms.Button buttonBewerkProduct;
        private System.Windows.Forms.Label labelKlant;
    }
}