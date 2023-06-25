namespace FixBrawlSaving
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadszs = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblwszst = new System.Windows.Forms.Label();
            this.lblszs = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.Button();
            this.saveszs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadszs
            // 
            this.loadszs.Location = new System.Drawing.Point(13, 13);
            this.loadszs.Name = "loadszs";
            this.loadszs.Size = new System.Drawing.Size(87, 28);
            this.loadszs.TabIndex = 0;
            this.loadszs.Text = "Load SZS File";
            this.loadszs.UseVisualStyleBackColor = true;
            this.loadszs.Click += new System.EventHandler(this.loadszs_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblwszst
            // 
            this.lblwszst.AutoSize = true;
            this.lblwszst.Location = new System.Drawing.Point(38, 57);
            this.lblwszst.Name = "lblwszst";
            this.lblwszst.Size = new System.Drawing.Size(35, 13);
            this.lblwszst.TabIndex = 1;
            this.lblwszst.Text = "label1";
            // 
            // lblszs
            // 
            this.lblszs.AutoSize = true;
            this.lblszs.Location = new System.Drawing.Point(38, 92);
            this.lblszs.Name = "lblszs";
            this.lblszs.Size = new System.Drawing.Size(97, 13);
            this.lblszs.TabIndex = 2;
            this.lblszs.Text = "Current SZS: None";
            // 
            // debug
            // 
            this.debug.Location = new System.Drawing.Point(134, 324);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(75, 23);
            this.debug.TabIndex = 3;
            this.debug.Text = "button2";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Click += new System.EventHandler(this.debug_Click);
            // 
            // saveszs
            // 
            this.saveszs.Location = new System.Drawing.Point(13, 157);
            this.saveszs.Name = "saveszs";
            this.saveszs.Size = new System.Drawing.Size(87, 28);
            this.saveszs.TabIndex = 4;
            this.saveszs.Text = "Save SZS file";
            this.saveszs.UseVisualStyleBackColor = true;
            this.saveszs.Click += new System.EventHandler(this.saveszs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveszs);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.lblszs);
            this.Controls.Add(this.lblwszst);
            this.Controls.Add(this.loadszs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadszs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblwszst;
        private System.Windows.Forms.Label lblszs;
        private System.Windows.Forms.Button debug;
        private System.Windows.Forms.Button saveszs;
    }
}

