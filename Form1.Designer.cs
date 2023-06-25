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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblwszst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.debug = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load SZS File";
            this.button1.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current SZS: None";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save SZS file";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblwszst);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblwszst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button debug;
        private System.Windows.Forms.Button button2;
    }
}

