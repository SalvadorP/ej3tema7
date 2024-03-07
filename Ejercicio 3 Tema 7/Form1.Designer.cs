namespace Ejercicio_3_Tema_7
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
            this.leerBtn = new System.Windows.Forms.Button();
            this.ordenarBtn = new System.Windows.Forms.Button();
            this.listarBtn = new System.Windows.Forms.Button();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leerBtn
            // 
            this.leerBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.leerBtn.Location = new System.Drawing.Point(302, 52);
            this.leerBtn.Name = "leerBtn";
            this.leerBtn.Size = new System.Drawing.Size(184, 35);
            this.leerBtn.TabIndex = 0;
            this.leerBtn.Text = "Leer fechas";
            this.leerBtn.UseVisualStyleBackColor = false;
            this.leerBtn.Click += new System.EventHandler(this.leerBtn_Click);
            // 
            // ordenarBtn
            // 
            this.ordenarBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.ordenarBtn.Location = new System.Drawing.Point(302, 116);
            this.ordenarBtn.Name = "ordenarBtn";
            this.ordenarBtn.Size = new System.Drawing.Size(184, 34);
            this.ordenarBtn.TabIndex = 1;
            this.ordenarBtn.Text = "Ordenar fechas";
            this.ordenarBtn.UseVisualStyleBackColor = false;
            this.ordenarBtn.Click += new System.EventHandler(this.ordenarBtn_Click);
            // 
            // listarBtn
            // 
            this.listarBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.listarBtn.Location = new System.Drawing.Point(302, 184);
            this.listarBtn.Name = "listarBtn";
            this.listarBtn.Size = new System.Drawing.Size(184, 34);
            this.listarBtn.TabIndex = 2;
            this.listarBtn.Text = "Listar fechas";
            this.listarBtn.UseVisualStyleBackColor = false;
            this.listarBtn.Click += new System.EventHandler(this.listarBtn_Click);
            // 
            // resultadoLabel
            // 
            this.resultadoLabel.AutoSize = true;
            this.resultadoLabel.Location = new System.Drawing.Point(302, 280);
            this.resultadoLabel.Name = "resultadoLabel";
            this.resultadoLabel.Size = new System.Drawing.Size(56, 19);
            this.resultadoLabel.TabIndex = 3;
            this.resultadoLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(889, 428);
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.listarBtn);
            this.Controls.Add(this.ordenarBtn);
            this.Controls.Add(this.leerBtn);
            this.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Ejercicio 3 Tema 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leerBtn;
        private System.Windows.Forms.Button ordenarBtn;
        private System.Windows.Forms.Button listarBtn;
        private System.Windows.Forms.Label resultadoLabel;
    }
}

