
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSemaforo));
            this.tmrVerde = new System.Windows.Forms.Timer(this.components);
            this.tmrVerdeParpadeando = new System.Windows.Forms.Timer(this.components);
            this.tmrAmarillo = new System.Windows.Forms.Timer(this.components);
            this.tmrRojo = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPreventivas = new System.Windows.Forms.Button();
            this.picHorizontalDerecha = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.picHorizontalIzquierda = new System.Windows.Forms.PictureBox();
            this.picVerticalAbajo = new System.Windows.Forms.PictureBox();
            this.picVerticalArriba = new System.Windows.Forms.PictureBox();
            this.txtContador = new System.Windows.Forms.Label();
            this.tmrPreventivas = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHorizontalDerecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorizontalIzquierda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerticalAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerticalArriba)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrVerde
            // 
            this.tmrVerde.Interval = 500;
            this.tmrVerde.Tick += new System.EventHandler(this.tmrVerde_Tick);
            // 
            // tmrVerdeParpadeando
            // 
            this.tmrVerdeParpadeando.Interval = 500;
            this.tmrVerdeParpadeando.Tick += new System.EventHandler(this.tmrVerdeParpadeando_Tick);
            // 
            // tmrAmarillo
            // 
            this.tmrAmarillo.Interval = 500;
            this.tmrAmarillo.Tick += new System.EventHandler(this.tmrAmarillo_Tick);
            // 
            // tmrRojo
            // 
            this.tmrRojo.Interval = 500;
            this.tmrRojo.Tick += new System.EventHandler(this.tmrRojo_Tick);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(824, 146);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(59, 47);
            this.btnPause.TabIndex = 29;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(824, 53);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(59, 47);
            this.btnPlay.TabIndex = 28;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPreventivas
            // 
            this.btnPreventivas.BackColor = System.Drawing.Color.Transparent;
            this.btnPreventivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreventivas.Image = ((System.Drawing.Image)(resources.GetObject("btnPreventivas.Image")));
            this.btnPreventivas.Location = new System.Drawing.Point(945, 146);
            this.btnPreventivas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreventivas.Name = "btnPreventivas";
            this.btnPreventivas.Size = new System.Drawing.Size(59, 47);
            this.btnPreventivas.TabIndex = 31;
            this.btnPreventivas.UseVisualStyleBackColor = false;
            this.btnPreventivas.Click += new System.EventHandler(this.btnPreventivas_Click);
            // 
            // picHorizontalDerecha
            // 
            this.picHorizontalDerecha.Image = ((System.Drawing.Image)(resources.GetObject("picHorizontalDerecha.Image")));
            this.picHorizontalDerecha.Location = new System.Drawing.Point(660, 538);
            this.picHorizontalDerecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHorizontalDerecha.Name = "picHorizontalDerecha";
            this.picHorizontalDerecha.Size = new System.Drawing.Size(156, 66);
            this.picHorizontalDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHorizontalDerecha.TabIndex = 35;
            this.picHorizontalDerecha.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(945, 53);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(59, 47);
            this.btnStop.TabIndex = 30;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // picHorizontalIzquierda
            // 
            this.picHorizontalIzquierda.Image = ((System.Drawing.Image)(resources.GetObject("picHorizontalIzquierda.Image")));
            this.picHorizontalIzquierda.Location = new System.Drawing.Point(243, 272);
            this.picHorizontalIzquierda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHorizontalIzquierda.Name = "picHorizontalIzquierda";
            this.picHorizontalIzquierda.Size = new System.Drawing.Size(156, 66);
            this.picHorizontalIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHorizontalIzquierda.TabIndex = 34;
            this.picHorizontalIzquierda.TabStop = false;
            // 
            // picVerticalAbajo
            // 
            this.picVerticalAbajo.Image = ((System.Drawing.Image)(resources.GetObject("picVerticalAbajo.Image")));
            this.picVerticalAbajo.Location = new System.Drawing.Point(332, 538);
            this.picVerticalAbajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picVerticalAbajo.Name = "picVerticalAbajo";
            this.picVerticalAbajo.Size = new System.Drawing.Size(67, 156);
            this.picVerticalAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerticalAbajo.TabIndex = 33;
            this.picVerticalAbajo.TabStop = false;
            // 
            // picVerticalArriba
            // 
            this.picVerticalArriba.Image = ((System.Drawing.Image)(resources.GetObject("picVerticalArriba.Image")));
            this.picVerticalArriba.Location = new System.Drawing.Point(660, 182);
            this.picVerticalArriba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picVerticalArriba.Name = "picVerticalArriba";
            this.picVerticalArriba.Size = new System.Drawing.Size(67, 156);
            this.picVerticalArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerticalArriba.TabIndex = 32;
            this.picVerticalArriba.TabStop = false;
            // 
            // txtContador
            // 
            this.txtContador.AutoSize = true;
            this.txtContador.BackColor = System.Drawing.Color.Transparent;
            this.txtContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContador.ForeColor = System.Drawing.Color.White;
            this.txtContador.Location = new System.Drawing.Point(481, 390);
            this.txtContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(83, 91);
            this.txtContador.TabIndex = 27;
            this.txtContador.Text = "0";
            // 
            // tmrPreventivas
            // 
            this.tmrPreventivas.Interval = 500;
            this.tmrPreventivas.Tick += new System.EventHandler(this.tmrPreventivas_Tick);
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
            this.Controls.Add(this.picHorizontalDerecha);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.picHorizontalIzquierda);
            this.Controls.Add(this.picVerticalAbajo);
            this.Controls.Add(this.picVerticalArriba);
            this.Controls.Add(this.txtContador);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSemaforo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semaforo";
            this.Load += new System.EventHandler(this.frmSemaforo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHorizontalDerecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHorizontalIzquierda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerticalAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerticalArriba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrVerde;
        private System.Windows.Forms.Timer tmrVerdeParpadeando;
        private System.Windows.Forms.Timer tmrAmarillo;
        private System.Windows.Forms.Timer tmrRojo;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPreventivas;
        private System.Windows.Forms.PictureBox picHorizontalDerecha;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox picHorizontalIzquierda;
        private System.Windows.Forms.PictureBox picVerticalAbajo;
        private System.Windows.Forms.PictureBox picVerticalArriba;
        private System.Windows.Forms.Label txtContador;
        private System.Windows.Forms.Timer tmrPreventivas;
    }
}

