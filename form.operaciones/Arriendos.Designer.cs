namespace form.operaciones
{
    partial class Arriendos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arriendos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt1Arriendo = new System.Windows.Forms.TextBox();
            this.txt2Arriendo = new System.Windows.Forms.TextBox();
            this.txt3Arriendo = new System.Windows.Forms.TextBox();
            this.grpboxAumento = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt1AumArri = new System.Windows.Forms.TextBox();
            this.txt2AumArri = new System.Windows.Forms.TextBox();
            this.txt3AumArri = new System.Windows.Forms.TextBox();
            this.grpboxTotal = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.txtTotal3 = new System.Windows.Forms.TextBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpboxAumento.SuspendLayout();
            this.grpboxTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor primer arriendo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor segundo arriendo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor tercer arriendo:";
            // 
            // txt1Arriendo
            // 
            this.txt1Arriendo.Location = new System.Drawing.Point(218, 91);
            this.txt1Arriendo.Name = "txt1Arriendo";
            this.txt1Arriendo.Size = new System.Drawing.Size(100, 20);
            this.txt1Arriendo.TabIndex = 3;
            // 
            // txt2Arriendo
            // 
            this.txt2Arriendo.Location = new System.Drawing.Point(218, 129);
            this.txt2Arriendo.Name = "txt2Arriendo";
            this.txt2Arriendo.Size = new System.Drawing.Size(100, 20);
            this.txt2Arriendo.TabIndex = 4;
            // 
            // txt3Arriendo
            // 
            this.txt3Arriendo.Location = new System.Drawing.Point(218, 169);
            this.txt3Arriendo.Name = "txt3Arriendo";
            this.txt3Arriendo.Size = new System.Drawing.Size(100, 20);
            this.txt3Arriendo.TabIndex = 5;
            // 
            // grpboxAumento
            // 
            this.grpboxAumento.Controls.Add(this.txt3AumArri);
            this.grpboxAumento.Controls.Add(this.txt2AumArri);
            this.grpboxAumento.Controls.Add(this.txt1AumArri);
            this.grpboxAumento.Controls.Add(this.label7);
            this.grpboxAumento.Controls.Add(this.label6);
            this.grpboxAumento.Controls.Add(this.label5);
            this.grpboxAumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxAumento.Location = new System.Drawing.Point(218, 245);
            this.grpboxAumento.Name = "grpboxAumento";
            this.grpboxAumento.Size = new System.Drawing.Size(235, 161);
            this.grpboxAumento.TabIndex = 6;
            this.grpboxAumento.TabStop = false;
            this.grpboxAumento.Text = "Arriendo con aunmento del 8%";
            this.grpboxAumento.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arriendos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Arriendo 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Arriendo 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Arriendo 3:";
            // 
            // txt1AumArri
            // 
            this.txt1AumArri.Enabled = false;
            this.txt1AumArri.Location = new System.Drawing.Point(120, 47);
            this.txt1AumArri.Name = "txt1AumArri";
            this.txt1AumArri.Size = new System.Drawing.Size(100, 22);
            this.txt1AumArri.TabIndex = 3;
            // 
            // txt2AumArri
            // 
            this.txt2AumArri.Enabled = false;
            this.txt2AumArri.Location = new System.Drawing.Point(120, 74);
            this.txt2AumArri.Name = "txt2AumArri";
            this.txt2AumArri.Size = new System.Drawing.Size(100, 22);
            this.txt2AumArri.TabIndex = 4;
            // 
            // txt3AumArri
            // 
            this.txt3AumArri.Enabled = false;
            this.txt3AumArri.Location = new System.Drawing.Point(120, 101);
            this.txt3AumArri.Name = "txt3AumArri";
            this.txt3AumArri.Size = new System.Drawing.Size(100, 22);
            this.txt3AumArri.TabIndex = 5;
            // 
            // grpboxTotal
            // 
            this.grpboxTotal.Controls.Add(this.txtTotal3);
            this.grpboxTotal.Controls.Add(this.txtTotal2);
            this.grpboxTotal.Controls.Add(this.txtTotal1);
            this.grpboxTotal.Controls.Add(this.label8);
            this.grpboxTotal.Controls.Add(this.label9);
            this.grpboxTotal.Controls.Add(this.label10);
            this.grpboxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxTotal.Location = new System.Drawing.Point(476, 245);
            this.grpboxTotal.Name = "grpboxTotal";
            this.grpboxTotal.Size = new System.Drawing.Size(227, 161);
            this.grpboxTotal.TabIndex = 8;
            this.grpboxTotal.TabStop = false;
            this.grpboxTotal.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Arriendo 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Arriendo 2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Arriendo 1:";
            // 
            // txtTotal1
            // 
            this.txtTotal1.Enabled = false;
            this.txtTotal1.Location = new System.Drawing.Point(110, 42);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(100, 22);
            this.txtTotal1.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(400, 112);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 40);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotal2
            // 
            this.txtTotal2.Enabled = false;
            this.txtTotal2.Location = new System.Drawing.Point(110, 69);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.Size = new System.Drawing.Size(100, 22);
            this.txtTotal2.TabIndex = 7;
            // 
            // txtTotal3
            // 
            this.txtTotal3.Enabled = false;
            this.txtTotal3.Location = new System.Drawing.Point(110, 96);
            this.txtTotal3.Name = "txtTotal3";
            this.txtTotal3.Size = new System.Drawing.Size(100, 22);
            this.txtTotal3.TabIndex = 8;
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(679, 34);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(79, 37);
            this.btnMain.TabIndex = 10;
            this.btnMain.Text = "Volver";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(679, 75);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 37);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Arriendos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpboxTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpboxAumento);
            this.Controls.Add(this.txt3Arriendo);
            this.Controls.Add(this.txt2Arriendo);
            this.Controls.Add(this.txt1Arriendo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Arriendos";
            this.Text = "Arriendos";
            this.grpboxAumento.ResumeLayout(false);
            this.grpboxAumento.PerformLayout();
            this.grpboxTotal.ResumeLayout(false);
            this.grpboxTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1Arriendo;
        private System.Windows.Forms.TextBox txt2Arriendo;
        private System.Windows.Forms.TextBox txt3Arriendo;
        private System.Windows.Forms.GroupBox grpboxAumento;
        private System.Windows.Forms.TextBox txt3AumArri;
        private System.Windows.Forms.TextBox txt2AumArri;
        private System.Windows.Forms.TextBox txt1AumArri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpboxTotal;
        private System.Windows.Forms.TextBox txtTotal3;
        private System.Windows.Forms.TextBox txtTotal2;
        private System.Windows.Forms.TextBox txtTotal1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnLimpiar;
    }
}