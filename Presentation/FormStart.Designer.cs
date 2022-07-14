
namespace Presentation
{
    partial class FormStart
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
            this.buttonNieuweFactuur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNieuweFactuur
            // 
            this.buttonNieuweFactuur.Location = new System.Drawing.Point(293, 134);
            this.buttonNieuweFactuur.Name = "buttonNieuweFactuur";
            this.buttonNieuweFactuur.Size = new System.Drawing.Size(213, 76);
            this.buttonNieuweFactuur.TabIndex = 0;
            this.buttonNieuweFactuur.Text = "Nieuwe factuur";
            this.buttonNieuweFactuur.UseVisualStyleBackColor = true;
            this.buttonNieuweFactuur.Click += new System.EventHandler(this.buttonNieuweFactuur_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNieuweFactuur);
            this.Name = "FormStart";
            this.Text = "TCG Card Grading";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNieuweFactuur;
    }
}

