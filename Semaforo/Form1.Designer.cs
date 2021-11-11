
namespace Semaforo
{
    partial class frmSemaforo
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
            this.components = new System.ComponentModel.Container();
            this.tmrVerde = new System.Windows.Forms.Timer(this.components);
            this.tmrVerdeParpadeando = new System.Windows.Forms.Timer(this.components);
            this.tmrAmarillo = new System.Windows.Forms.Timer(this.components);
            this.tmrAmarilloParpadeando = new System.Windows.Forms.Timer(this.components);
            this.tmrRojo = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPreventivas = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtContador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrVerde
            // 
            this.tmrVerde.Interval = 1000;
            this.tmrVerde.Tick += new System.EventHandler(this.tmrVerde_Tick);
            // 
            // tmrVerdeParpadeando
            // 
            this.tmrVerdeParpadeando.Interval = 500;
            this.tmrVerdeParpadeando.Tick += new System.EventHandler(this.tmrVerdeParpadeando_Tick);
            // 
            // tmrAmarillo
            // 
            this.tmrAmarillo.Interval = 1000;
            this.tmrAmarillo.Tick += new System.EventHandler(this.tmrAmarillo_Tick);
            // 
            // tmrRojo
            // 
            this.tmrRojo.Interval = 1000;
            this.tmrRojo.Tick += new System.EventHandler(this.tmrRojo_Tick);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = global::Semaforo.Properties.Resources.pausa__1_;
            this.btnPause.Location = new System.Drawing.Point(824, 146);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(58, 47);
            this.btnPause.TabIndex = 29;
            this.btnPause.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::Semaforo.Properties.Resources.play__1_;
            this.btnPlay.Location = new System.Drawing.Point(824, 53);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(58, 47);
            this.btnPlay.TabIndex = 28;
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnPreventivas
            // 
            this.btnPreventivas.BackColor = System.Drawing.Color.Transparent;
            this.btnPreventivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreventivas.Image = global::Semaforo.Properties.Resources.warning__1_;
            this.btnPreventivas.Location = new System.Drawing.Point(945, 146);
            this.btnPreventivas.Name = "btnPreventivas";
            this.btnPreventivas.Size = new System.Drawing.Size(58, 47);
            this.btnPreventivas.TabIndex = 31;
            this.btnPreventivas.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Semaforo.Properties.Resources.apagado_horizontal;
            this.pictureBox4.Location = new System.Drawing.Point(670, 555);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(156, 67);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = global::Semaforo.Properties.Resources.stop__1_;
            this.btnStop.Location = new System.Drawing.Point(945, 53);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(58, 47);
            this.btnStop.TabIndex = 30;
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Semaforo.Properties.Resources.apagado_horizontal;
            this.pictureBox3.Location = new System.Drawing.Point(243, 272);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(156, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Semaforo.Properties.Resources.apagado_vertical;
            this.pictureBox2.Location = new System.Drawing.Point(332, 555);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Semaforo.Properties.Resources.apagado_vertical;
            this.pictureBox1.Location = new System.Drawing.Point(660, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // txtContador
            // 
            this.txtContador.AutoSize = true;
            this.txtContador.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtContador.Location = new System.Drawing.Point(491, 387);
            this.txtContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(83, 91);
            this.txtContador.TabIndex = 27;
            this.txtContador.Text = "0";
            // 
            // frmSemaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Semaforo.Properties.Resources.dise_o_crucesemaforos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1061, 860);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPreventivas);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContador);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSemaforo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semaforo";
            this.Load += new System.EventHandler(this.frmSemaforo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrVerde;
        private System.Windows.Forms.Timer tmrVerdeParpadeando;
        private System.Windows.Forms.Timer tmrAmarillo;
        private System.Windows.Forms.Timer tmrAmarilloParpadeando;
        private System.Windows.Forms.Timer tmrRojo;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPreventivas;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtContador;
    }
}

