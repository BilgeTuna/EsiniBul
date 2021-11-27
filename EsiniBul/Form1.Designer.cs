
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
            this.pnlEsiniBul = new System.Windows.Forms.Panel();
            this.btnTekrarOyna = new System.Windows.Forms.Button();
            this.pnlEsiniBul.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEsiniBul
            // 
            this.pnlEsiniBul.Controls.Add(this.btnTekrarOyna);
            this.pnlEsiniBul.Location = new System.Drawing.Point(12, 12);
            this.pnlEsiniBul.Name = "pnlEsiniBul";
            this.pnlEsiniBul.Size = new System.Drawing.Size(594, 606);
            this.pnlEsiniBul.TabIndex = 0;
            // 
            // btnTekrarOyna
            // 
            this.btnTekrarOyna.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTekrarOyna.Location = new System.Drawing.Point(179, 216);
            this.btnTekrarOyna.Name = "btnTekrarOyna";
            this.btnTekrarOyna.Size = new System.Drawing.Size(214, 88);
            this.btnTekrarOyna.TabIndex = 0;
            this.btnTekrarOyna.Text = "TEKRAR OYNA";
            this.btnTekrarOyna.UseVisualStyleBackColor = true;
            this.btnTekrarOyna.Visible = false;
            this.btnTekrarOyna.Click += new System.EventHandler(this.btnTekrarOyna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 630);
            this.Controls.Add(this.pnlEsiniBul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlEsiniBul.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEsiniBul;
        private System.Windows.Forms.Button btnTekrarOyna;
    }
}

