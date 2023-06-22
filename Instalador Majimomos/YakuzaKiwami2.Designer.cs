namespace Instalador_Majimomos
{
    partial class YakuzaKiwami2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.majima = new System.Windows.Forms.RadioButton();
            this.kiryu = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SKCM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 20);
            this.textBox1.TabIndex = 0;
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(531, 41);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(21, 20);
            this.path.TabIndex = 1;
            this.path.Text = "...";
            this.path.UseVisualStyleBackColor = true;
            this.path.Click += new System.EventHandler(this.path_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.majima);
            this.groupBox1.Controls.Add(this.kiryu);
            this.groupBox1.Location = new System.Drawing.Point(55, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione su Version del Juego";
            // 
            // majima
            // 
            this.majima.AutoSize = true;
            this.majima.Location = new System.Drawing.Point(5, 41);
            this.majima.Name = "majima";
            this.majima.Size = new System.Drawing.Size(78, 17);
            this.majima.TabIndex = 4;
            this.majima.TabStop = true;
            this.majima.Text = "Gamepass";
            this.majima.UseVisualStyleBackColor = true;
            this.majima.CheckedChanged += new System.EventHandler(this.majima_CheckedChanged);
            // 
            // kiryu
            // 
            this.kiryu.AutoSize = true;
            this.kiryu.Location = new System.Drawing.Point(5, 19);
            this.kiryu.Name = "kiryu";
            this.kiryu.Size = new System.Drawing.Size(58, 17);
            this.kiryu.TabIndex = 3;
            this.kiryu.TabStop = true;
            this.kiryu.Text = "Steam";
            this.kiryu.UseVisualStyleBackColor = true;
            this.kiryu.CheckedChanged += new System.EventHandler(this.kiryu_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(153, 81);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(372, 35);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // SKCM
            // 
            this.SKCM.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SKCM.Location = new System.Drawing.Point(456, 184);
            this.SKCM.Name = "SKCM";
            this.SKCM.Size = new System.Drawing.Size(153, 66);
            this.SKCM.TabIndex = 5;
            this.SKCM.Text = "Instalar Traduccion";
            this.SKCM.UseVisualStyleBackColor = true;
            this.SKCM.Click += new System.EventHandler(this.SKCM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 9F);
            this.label2.Location = new System.Drawing.Point(153, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 14);
            this.label2.TabIndex = 6;
            // 
            // YakuzaKiwami2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SKCM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.textBox1);
            this.Name = "YakuzaKiwami2";
            this.Text = "Asistente de Instalacion de Yakuza Kiwami 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button path;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton majima;
        private System.Windows.Forms.RadioButton kiryu;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SKCM;
        private System.Windows.Forms.Label label2;
    }
}