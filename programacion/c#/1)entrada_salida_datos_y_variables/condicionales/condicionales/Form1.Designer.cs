
namespace condicionales
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.btn_checar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "texto";
            // 
            // txt_texto
            // 
            this.txt_texto.Location = new System.Drawing.Point(15, 41);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(317, 20);
            this.txt_texto.TabIndex = 4;
            // 
            // btn_checar
            // 
            this.btn_checar.Location = new System.Drawing.Point(12, 91);
            this.btn_checar.Name = "btn_checar";
            this.btn_checar.Size = new System.Drawing.Size(320, 23);
            this.btn_checar.TabIndex = 6;
            this.btn_checar.Text = "checar cual es mayor";
            this.btn_checar.UseVisualStyleBackColor = true;
            this.btn_checar.Click += new System.EventHandler(this.btn_checar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 126);
            this.Controls.Add(this.btn_checar);
            this.Controls.Add(this.txt_texto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "QUE NUMERO ES MAYOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_texto;
        private System.Windows.Forms.Button btn_checar;
    }
}

