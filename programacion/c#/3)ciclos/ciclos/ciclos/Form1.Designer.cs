
namespace ciclos
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
            this.txt_num_repeticiones = new System.Windows.Forms.TextBox();
            this.btn_iniciar_repeticiones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_num_repeticiones
            // 
            this.txt_num_repeticiones.Location = new System.Drawing.Point(12, 12);
            this.txt_num_repeticiones.Name = "txt_num_repeticiones";
            this.txt_num_repeticiones.Size = new System.Drawing.Size(100, 20);
            this.txt_num_repeticiones.TabIndex = 0;
            // 
            // btn_iniciar_repeticiones
            // 
            this.btn_iniciar_repeticiones.Location = new System.Drawing.Point(128, 3);
            this.btn_iniciar_repeticiones.Name = "btn_iniciar_repeticiones";
            this.btn_iniciar_repeticiones.Size = new System.Drawing.Size(75, 36);
            this.btn_iniciar_repeticiones.TabIndex = 1;
            this.btn_iniciar_repeticiones.Text = "iniciar repeticiones";
            this.btn_iniciar_repeticiones.UseVisualStyleBackColor = true;
            this.btn_iniciar_repeticiones.Click += new System.EventHandler(this.btn_iniciar_repeticiones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 56);
            this.Controls.Add(this.btn_iniciar_repeticiones);
            this.Controls.Add(this.txt_num_repeticiones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num_repeticiones;
        private System.Windows.Forms.Button btn_iniciar_repeticiones;
    }
}

