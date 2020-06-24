namespace alarimDakka
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
            this.components = new System.ComponentModel.Container();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSurekutusu = new System.Windows.Forms.TextBox();
            this.btnSureBaslat = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDk = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnSifirla
            // 
            this.btnSifirla.Font = new System.Drawing.Font("Trajan Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSifirla.Location = new System.Drawing.Point(12, 194);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(184, 51);
            this.btnSifirla.TabIndex = 15;
            this.btnSifirla.Text = "SIFIRLA";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.Button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pixeled", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 75);
            this.label1.TabIndex = 12;
            this.label1.Text = "000";
            // 
            // tbSurekutusu
            // 
            this.tbSurekutusu.Location = new System.Drawing.Point(22, 86);
            this.tbSurekutusu.MaxLength = 3;
            this.tbSurekutusu.Name = "tbSurekutusu";
            this.tbSurekutusu.Size = new System.Drawing.Size(32, 20);
            this.tbSurekutusu.TabIndex = 11;
            // 
            // btnSureBaslat
            // 
            this.btnSureBaslat.Font = new System.Drawing.Font("Trajan Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSureBaslat.Location = new System.Drawing.Point(12, 80);
            this.btnSureBaslat.Name = "btnSureBaslat";
            this.btnSureBaslat.Size = new System.Drawing.Size(184, 33);
            this.btnSureBaslat.TabIndex = 10;
            this.btnSureBaslat.Text = "SÜREYİ BAŞLAT (DK)";
            this.btnSureBaslat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSureBaslat.UseVisualStyleBackColor = true;
            this.btnSureBaslat.Click += new System.EventHandler(this.btnSureBaslat_Click);
            // 
            // btn25
            // 
            this.btn25.Font = new System.Drawing.Font("Pixeled", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn25.Location = new System.Drawing.Point(139, 12);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(57, 59);
            this.btn25.TabIndex = 7;
            this.btn25.Text = "25";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.btn25_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Pixeled", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button2.Location = new System.Drawing.Point(75, 12);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(57, 59);
            this.Button2.TabIndex = 8;
            this.Button2.Text = "20";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Pixeled", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button1.Location = new System.Drawing.Point(12, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(57, 59);
            this.Button1.TabIndex = 9;
            this.Button1.Text = "5";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDk
            // 
            this.labelDk.AutoSize = true;
            this.labelDk.BackColor = System.Drawing.Color.Transparent;
            this.labelDk.Font = new System.Drawing.Font("Trajan Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDk.Location = new System.Drawing.Point(154, 169);
            this.labelDk.Name = "labelDk";
            this.labelDk.Size = new System.Drawing.Size(33, 14);
            this.labelDk.TabIndex = 16;
            this.labelDk.Text = "0 dk";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 163);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(185, 25);
            this.progressBar1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 259);
            this.Controls.Add(this.labelDk);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.tbSurekutusu);
            this.Controls.Add(this.btnSureBaslat);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AlarimDakka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSifirla;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox tbSurekutusu;
        internal System.Windows.Forms.Button btnSureBaslat;
        internal System.Windows.Forms.Button btn25;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDk;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

