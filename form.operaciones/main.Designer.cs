namespace form.operaciones
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAutorApodo = new System.Windows.Forms.Label();
            this.btnFormGrl = new System.Windows.Forms.Button();
            this.btnArriendo = new System.Windows.Forms.Button();
            this.btnDivisas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(132, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(536, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "RESOLVIENDO OPERACIONES MATEMÁTICAS EN C# ";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAutor.Location = new System.Drawing.Point(550, 384);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(238, 20);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Lina Maria Montaño Ramirez";
            this.lblAutor.Click += new System.EventHandler(this.lblAutor_Click);
            // 
            // lblAutorApodo
            // 
            this.lblAutorApodo.AutoSize = true;
            this.lblAutorApodo.BackColor = System.Drawing.Color.Transparent;
            this.lblAutorApodo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAutorApodo.Location = new System.Drawing.Point(698, 404);
            this.lblAutorApodo.Name = "lblAutorApodo";
            this.lblAutorApodo.Size = new System.Drawing.Size(90, 13);
            this.lblAutorApodo.TabIndex = 2;
            this.lblAutorApodo.Text = "@calypso_bronte";
            // 
            // btnFormGrl
            // 
            this.btnFormGrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormGrl.Location = new System.Drawing.Point(43, 191);
            this.btnFormGrl.Name = "btnFormGrl";
            this.btnFormGrl.Size = new System.Drawing.Size(190, 36);
            this.btnFormGrl.TabIndex = 3;
            this.btnFormGrl.Text = "Fórmula General";
            this.btnFormGrl.UseVisualStyleBackColor = true;
            this.btnFormGrl.Click += new System.EventHandler(this.btnFormGrl_Click);
            // 
            // btnArriendo
            // 
            this.btnArriendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArriendo.Location = new System.Drawing.Point(305, 191);
            this.btnArriendo.Name = "btnArriendo";
            this.btnArriendo.Size = new System.Drawing.Size(190, 36);
            this.btnArriendo.TabIndex = 4;
            this.btnArriendo.Text = "Calcular Arriendo";
            this.btnArriendo.UseVisualStyleBackColor = true;
            this.btnArriendo.Click += new System.EventHandler(this.btnArriendo_Click);
            // 
            // btnDivisas
            // 
            this.btnDivisas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisas.Location = new System.Drawing.Point(566, 193);
            this.btnDivisas.Name = "btnDivisas";
            this.btnDivisas.Size = new System.Drawing.Size(190, 36);
            this.btnDivisas.TabIndex = 5;
            this.btnDivisas.Text = "Calcular Divisas";
            this.btnDivisas.UseVisualStyleBackColor = true;
            this.btnDivisas.Click += new System.EventHandler(this.btnDivisas_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDivisas);
            this.Controls.Add(this.btnArriendo);
            this.Controls.Add(this.btnFormGrl);
            this.Controls.Add(this.lblAutorApodo);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblAutorApodo;
        private System.Windows.Forms.Button btnFormGrl;
        private System.Windows.Forms.Button btnArriendo;
        private System.Windows.Forms.Button btnDivisas;
    }
}