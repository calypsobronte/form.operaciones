namespace form.operaciones
{
    partial class formulaGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulaGeneral));
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.txtbA = new System.Windows.Forms.TextBox();
            this.txtbB = new System.Windows.Forms.TextBox();
            this.txtbC = new System.Windows.Forms.TextBox();
            this.grpboxOperacion = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.ptboxRaiz = new System.Windows.Forms.PictureBox();
            this.btnCalOpe = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.grpboxOperacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptboxRaiz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fórmula General";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(60, 142);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(25, 25);
            this.a.TabIndex = 1;
            this.a.Text = "a";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(60, 170);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(25, 25);
            this.b.TabIndex = 2;
            this.b.Text = "b";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(60, 202);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(24, 25);
            this.c.TabIndex = 3;
            this.c.Text = "c";
            // 
            // txtbA
            // 
            this.txtbA.Location = new System.Drawing.Point(119, 146);
            this.txtbA.Name = "txtbA";
            this.txtbA.Size = new System.Drawing.Size(83, 20);
            this.txtbA.TabIndex = 4;
            // 
            // txtbB
            // 
            this.txtbB.Location = new System.Drawing.Point(119, 174);
            this.txtbB.Name = "txtbB";
            this.txtbB.Size = new System.Drawing.Size(83, 20);
            this.txtbB.TabIndex = 5;
            // 
            // txtbC
            // 
            this.txtbC.Location = new System.Drawing.Point(119, 206);
            this.txtbC.Name = "txtbC";
            this.txtbC.Size = new System.Drawing.Size(83, 20);
            this.txtbC.TabIndex = 6;
            // 
            // grpboxOperacion
            // 
            this.grpboxOperacion.Controls.Add(this.txtResult);
            this.grpboxOperacion.Controls.Add(this.label2);
            this.grpboxOperacion.Controls.Add(this.lblOperacion);
            this.grpboxOperacion.Location = new System.Drawing.Point(250, 125);
            this.grpboxOperacion.Name = "grpboxOperacion";
            this.grpboxOperacion.Size = new System.Drawing.Size(267, 120);
            this.grpboxOperacion.TabIndex = 7;
            this.grpboxOperacion.TabStop = false;
            this.grpboxOperacion.Text = "Operación Raíz";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(108, 62);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(142, 20);
            this.txtResult.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado:";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(32, 22);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(202, 20);
            this.lblOperacion.TabIndex = 0;
            this.lblOperacion.Text = "[-b+(b^2-4ac)^(1/2)]/(2a)";
            // 
            // ptboxRaiz
            // 
            this.ptboxRaiz.Image = ((System.Drawing.Image)(resources.GetObject("ptboxRaiz.Image")));
            this.ptboxRaiz.Location = new System.Drawing.Point(325, 23);
            this.ptboxRaiz.Name = "ptboxRaiz";
            this.ptboxRaiz.Size = new System.Drawing.Size(192, 62);
            this.ptboxRaiz.TabIndex = 8;
            this.ptboxRaiz.TabStop = false;
            // 
            // btnCalOpe
            // 
            this.btnCalOpe.AccessibleDescription = "Calcular Operación";
            this.btnCalOpe.AccessibleName = "Calcular Operación";
            this.btnCalOpe.Location = new System.Drawing.Point(442, 265);
            this.btnCalOpe.Name = "btnCalOpe";
            this.btnCalOpe.Size = new System.Drawing.Size(75, 23);
            this.btnCalOpe.TabIndex = 9;
            this.btnCalOpe.Text = "Calcular";
            this.btnCalOpe.UseVisualStyleBackColor = true;
            this.btnCalOpe.Click += new System.EventHandler(this.btnCalOpe_Click);
            // 
            // main
            // 
            this.main.AccessibleDescription = "inicio";
            this.main.AccessibleName = "inicio";
            this.main.Location = new System.Drawing.Point(39, 334);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(75, 23);
            this.main.TabIndex = 10;
            this.main.Text = "Volver";
            this.main.UseVisualStyleBackColor = true;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // clear
            // 
            this.clear.AccessibleDescription = "Limpiar";
            this.clear.AccessibleName = "Limpiar";
            this.clear.Location = new System.Drawing.Point(133, 334);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 11;
            this.clear.Text = "Nuevo";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // formulaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 369);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.main);
            this.Controls.Add(this.btnCalOpe);
            this.Controls.Add(this.ptboxRaiz);
            this.Controls.Add(this.grpboxOperacion);
            this.Controls.Add(this.txtbC);
            this.Controls.Add(this.txtbB);
            this.Controls.Add(this.txtbA);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formulaGeneral";
            this.Text = "formulaGeneral";
            this.grpboxOperacion.ResumeLayout(false);
            this.grpboxOperacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptboxRaiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.TextBox txtbA;
        private System.Windows.Forms.TextBox txtbB;
        private System.Windows.Forms.TextBox txtbC;
        private System.Windows.Forms.GroupBox grpboxOperacion;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.PictureBox ptboxRaiz;
        private System.Windows.Forms.Button btnCalOpe;
        private System.Windows.Forms.Button main;
        private System.Windows.Forms.Button clear;
    }
}