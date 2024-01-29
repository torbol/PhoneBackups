namespace PhoneBackups
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_backup = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_startdaemon = new System.Windows.Forms.Button();
            this.checkBox1_phonedetected = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_backup
            // 
            this.button_backup.Location = new System.Drawing.Point(140, 89);
            this.button_backup.Name = "button_backup";
            this.button_backup.Size = new System.Drawing.Size(161, 53);
            this.button_backup.TabIndex = 0;
            this.button_backup.Text = "Backup";
            this.button_backup.UseVisualStyleBackColor = true;
            this.button_backup.Click += new System.EventHandler(this.Button_backup_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(343, 354);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 1;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // button_startdaemon
            // 
            this.button_startdaemon.Location = new System.Drawing.Point(140, 29);
            this.button_startdaemon.Name = "button_startdaemon";
            this.button_startdaemon.Size = new System.Drawing.Size(161, 53);
            this.button_startdaemon.TabIndex = 2;
            this.button_startdaemon.Text = "Start Daemon and connect";
            this.button_startdaemon.UseVisualStyleBackColor = true;
            this.button_startdaemon.Click += new System.EventHandler(this.Button_startdaemon_Click);
            // 
            // checkBox1_phonedetected
            // 
            this.checkBox1_phonedetected.AutoCheck = false;
            this.checkBox1_phonedetected.AutoSize = true;
            this.checkBox1_phonedetected.Enabled = false;
            this.checkBox1_phonedetected.Location = new System.Drawing.Point(316, 48);
            this.checkBox1_phonedetected.Name = "checkBox1_phonedetected";
            this.checkBox1_phonedetected.Size = new System.Drawing.Size(102, 17);
            this.checkBox1_phonedetected.TabIndex = 3;
            this.checkBox1_phonedetected.Text = "Phone detected";
            this.checkBox1_phonedetected.UseVisualStyleBackColor = true;
            this.checkBox1_phonedetected.CheckedChanged += new System.EventHandler(this.CheckBox1_phonedetected_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(406, 182);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 389);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1_phonedetected);
            this.Controls.Add(this.button_startdaemon);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_backup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PhoneBackups";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_backup;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_startdaemon;
        private System.Windows.Forms.CheckBox checkBox1_phonedetected;
        private System.Windows.Forms.TextBox textBox1;
    }
}

