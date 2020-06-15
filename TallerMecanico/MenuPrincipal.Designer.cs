namespace TallerMecanico
{
    partial class MenuPrincipal
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
            this.btnServicio = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPiezas = new System.Windows.Forms.Button();
            this.btnAutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServicio
            // 
            this.btnServicio.Location = new System.Drawing.Point(26, 29);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(164, 66);
            this.btnServicio.TabIndex = 3;
            this.btnServicio.Text = "Alta de Servicio";
            this.btnServicio.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(26, 110);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(164, 66);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Catalogo de Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPiezas
            // 
            this.btnPiezas.Location = new System.Drawing.Point(26, 195);
            this.btnPiezas.Name = "btnPiezas";
            this.btnPiezas.Size = new System.Drawing.Size(164, 66);
            this.btnPiezas.TabIndex = 4;
            this.btnPiezas.Text = "Catalogo de Piezas";
            this.btnPiezas.UseVisualStyleBackColor = true;
            this.btnPiezas.Click += new System.EventHandler(this.btnPiezas_Click);
            // 
            // btnAutos
            // 
            this.btnAutos.Location = new System.Drawing.Point(26, 280);
            this.btnAutos.Name = "btnAutos";
            this.btnAutos.Size = new System.Drawing.Size(164, 66);
            this.btnAutos.TabIndex = 5;
            this.btnAutos.Text = "Catalogo de Autos";
            this.btnAutos.UseVisualStyleBackColor = true;
            this.btnAutos.Click += new System.EventHandler(this.btnAutos_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 372);
            this.Controls.Add(this.btnAutos);
            this.Controls.Add(this.btnPiezas);
            this.Controls.Add(this.btnServicio);
            this.Controls.Add(this.btnClientes);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServicio;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPiezas;
        private System.Windows.Forms.Button btnAutos;
    }
}