namespace Login
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
            this.bNinos = new System.Windows.Forms.Button();
            this.bElfo = new System.Windows.Forms.Button();
            this.bPapa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bNinos
            // 
            this.bNinos.BackColor = System.Drawing.Color.DarkRed;
            this.bNinos.BackgroundImage = global::Login.Properties.Resources.sobre;
            this.bNinos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNinos.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNinos.ForeColor = System.Drawing.Color.Black;
            this.bNinos.Location = new System.Drawing.Point(271, 142);
            this.bNinos.Name = "bNinos";
            this.bNinos.Size = new System.Drawing.Size(245, 88);
            this.bNinos.TabIndex = 3;
            this.bNinos.Text = "Manda la Carta a Papa Noel";
            this.bNinos.UseVisualStyleBackColor = false;
            // 
            // bElfo
            // 
            this.bElfo.BackgroundImage = global::Login.Properties.Resources.ocultacionElfo;
            this.bElfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bElfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bElfo.Location = new System.Drawing.Point(423, 345);
            this.bElfo.Name = "bElfo";
            this.bElfo.Size = new System.Drawing.Size(83, 66);
            this.bElfo.TabIndex = 2;
            this.bElfo.UseVisualStyleBackColor = true;
            this.bElfo.Click += new System.EventHandler(this.bElfo_Click);
            // 
            // bPapa
            // 
            this.bPapa.BackgroundImage = global::Login.Properties.Resources.ocultacionPapanoel;
            this.bPapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPapa.Location = new System.Drawing.Point(188, 324);
            this.bPapa.Name = "bPapa";
            this.bPapa.Size = new System.Drawing.Size(87, 72);
            this.bPapa.TabIndex = 1;
            this.bPapa.UseVisualStyleBackColor = true;
            this.bPapa.Click += new System.EventHandler(this.bPapa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.BannerPapappNoelEditado;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenidos a Papapp Noel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bNinos);
            this.Controls.Add(this.bElfo);
            this.Controls.Add(this.bPapa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bPapa;
        private System.Windows.Forms.Button bElfo;
        private System.Windows.Forms.Button bNinos;
        private System.Windows.Forms.Label label1;
    }
}

