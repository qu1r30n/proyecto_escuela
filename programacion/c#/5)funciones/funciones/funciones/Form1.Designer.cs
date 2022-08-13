
namespace funciones
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
            this.txt_datos = new System.Windows.Forms.TextBox();
            this.btn_datos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_datos
            // 
            this.txt_datos.Location = new System.Drawing.Point(12, 12);
            this.txt_datos.Name = "txt_datos";
            this.txt_datos.Size = new System.Drawing.Size(100, 20);
            this.txt_datos.TabIndex = 0;
            // 
            // btn_datos
            // 
            this.btn_datos.Location = new System.Drawing.Point(144, 12);
            this.btn_datos.Name = "btn_datos";
            this.btn_datos.Size = new System.Drawing.Size(75, 23);
            this.btn_datos.TabIndex = 1;
            this.btn_datos.Text = "procesar";
            this.btn_datos.UseVisualStyleBackColor = true;
            this.btn_datos.Click += new System.EventHandler(this.btn_datos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 190);
            this.Controls.Add(this.btn_datos);
            this.Controls.Add(this.txt_datos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_datos;
        private System.Windows.Forms.Button btn_datos;
    }
}

