
namespace EsiniBul
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
            this.pnlButonlar = new System.Windows.Forms.Panel();
            this.btnTekrarOyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlButonlar
            // 
            this.pnlButonlar.Location = new System.Drawing.Point(12, 12);
            this.pnlButonlar.Name = "pnlButonlar";
            this.pnlButonlar.Size = new System.Drawing.Size(652, 484);
            this.pnlButonlar.TabIndex = 0;
            // 
            // btnTekrarOyna
            // 
            this.btnTekrarOyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTekrarOyna.Location = new System.Drawing.Point(226, 164);
            this.btnTekrarOyna.Name = "btnTekrarOyna";
            this.btnTekrarOyna.Size = new System.Drawing.Size(179, 111);
            this.btnTekrarOyna.TabIndex = 0;
            this.btnTekrarOyna.Text = "Tekrar Oyna";
            this.btnTekrarOyna.UseVisualStyleBackColor = true;
            this.btnTekrarOyna.Visible = false;
            this.btnTekrarOyna.Click += new System.EventHandler(this.btnTekrarOyna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 498);
            this.Controls.Add(this.btnTekrarOyna);
            this.Controls.Add(this.pnlButonlar);
            this.Name = "Form1";
            this.Text = "Eşini Bul";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButonlar;
        private System.Windows.Forms.Button btnTekrarOyna;
    }
}

