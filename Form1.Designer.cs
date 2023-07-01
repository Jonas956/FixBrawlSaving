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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loadszs = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblwszst = new System.Windows.Forms.Label();
            this.lblszs = new System.Windows.Forms.Label();
            this.saveszs = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbdebug = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadszs
            // 
            this.loadszs.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadszs.Location = new System.Drawing.Point(0, 0);
            this.loadszs.Name = "loadszs";
            this.loadszs.Size = new System.Drawing.Size(432, 28);
            this.loadszs.TabIndex = 0;
            this.loadszs.Text = "Load SZS File";
            this.loadszs.UseVisualStyleBackColor = true;
            this.loadszs.Click += new System.EventHandler(this.loadszs_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Mario Kart Wii SZS files|*.szs";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Mario Kart Wii SZS files|*.szs";
            // 
            // lblwszst
            // 
            this.lblwszst.AutoSize = true;
            this.lblwszst.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblwszst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwszst.Location = new System.Drawing.Point(0, 28);
            this.lblwszst.Name = "lblwszst";
            this.lblwszst.Size = new System.Drawing.Size(46, 18);
            this.lblwszst.TabIndex = 1;
            this.lblwszst.Text = "label1";
            // 
            // lblszs
            // 
            this.lblszs.AutoSize = true;
            this.lblszs.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblszs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblszs.Location = new System.Drawing.Point(0, 46);
            this.lblszs.Name = "lblszs";
            this.lblszs.Size = new System.Drawing.Size(134, 18);
            this.lblszs.TabIndex = 2;
            this.lblszs.Text = "Current SZS: None";
            // 
            // saveszs
            // 
            this.saveszs.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveszs.Location = new System.Drawing.Point(0, 64);
            this.saveszs.Name = "saveszs";
            this.saveszs.Size = new System.Drawing.Size(432, 28);
            this.saveszs.TabIndex = 4;
            this.saveszs.Text = "Save SZS file";
            this.saveszs.UseVisualStyleBackColor = true;
            this.saveszs.Click += new System.EventHandler(this.saveszs_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblstatus.Location = new System.Drawing.Point(3, 104);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(119, 18);
            this.lblstatus.TabIndex = 5;
            this.lblstatus.Text = "Status: Waiting...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbdebug
            // 
            this.lbdebug.AutoSize = true;
            this.lbdebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbdebug.Location = new System.Drawing.Point(64, 205);
            this.lbdebug.Name = "lbdebug";
            this.lbdebug.Size = new System.Drawing.Size(60, 24);
            this.lbdebug.TabIndex = 7;
            this.lbdebug.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 374);
            this.Controls.Add(this.lbdebug);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.saveszs);
            this.Controls.Add(this.lblszs);
            this.Controls.Add(this.lblwszst);
            this.Controls.Add(this.loadszs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FixBrawlSaving v1.0";
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
        private System.Windows.Forms.Button saveszs;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbdebug;
    }
}

