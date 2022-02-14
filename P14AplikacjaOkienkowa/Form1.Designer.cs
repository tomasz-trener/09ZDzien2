
namespace P14AplikacjaOkienkowa
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnZamknij = new System.Windows.Forms.Button();
            this.txtNapis = new System.Windows.Forms.TextBox();
            this.lblNapis = new System.Windows.Forms.Label();
            this.bntOdczytaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 61);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Naciśnij mnie";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnZamknij
            // 
            this.btnZamknij.Location = new System.Drawing.Point(12, 403);
            this.btnZamknij.Name = "btnZamknij";
            this.btnZamknij.Size = new System.Drawing.Size(111, 35);
            this.btnZamknij.TabIndex = 1;
            this.btnZamknij.Text = "Zamknij";
            this.btnZamknij.UseVisualStyleBackColor = true;
            this.btnZamknij.Click += new System.EventHandler(this.btnZamknij_Click);
            // 
            // txtNapis
            // 
            this.txtNapis.Location = new System.Drawing.Point(140, 63);
            this.txtNapis.Name = "txtNapis";
            this.txtNapis.Size = new System.Drawing.Size(171, 20);
            this.txtNapis.TabIndex = 2;
            // 
            // lblNapis
            // 
            this.lblNapis.AutoSize = true;
            this.lblNapis.Location = new System.Drawing.Point(317, 66);
            this.lblNapis.Name = "lblNapis";
            this.lblNapis.Size = new System.Drawing.Size(35, 13);
            this.lblNapis.TabIndex = 3;
            this.lblNapis.Text = "label1";
            // 
            // bntOdczytaj
            // 
            this.bntOdczytaj.Location = new System.Drawing.Point(320, 33);
            this.bntOdczytaj.Name = "bntOdczytaj";
            this.bntOdczytaj.Size = new System.Drawing.Size(106, 23);
            this.bntOdczytaj.TabIndex = 4;
            this.bntOdczytaj.Text = "Odczytaj";
            this.bntOdczytaj.UseVisualStyleBackColor = true;
            this.bntOdczytaj.Click += new System.EventHandler(this.bntOdczytaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.bntOdczytaj);
            this.Controls.Add(this.lblNapis);
            this.Controls.Add(this.txtNapis);
            this.Controls.Add(this.btnZamknij);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnZamknij;
        private System.Windows.Forms.TextBox txtNapis;
        private System.Windows.Forms.Label lblNapis;
        private System.Windows.Forms.Button bntOdczytaj;
    }
}

