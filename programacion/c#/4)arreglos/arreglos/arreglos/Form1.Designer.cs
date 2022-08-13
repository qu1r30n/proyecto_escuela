
namespace arreglos
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
            this.txt_cantidad_datos = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.txt_datos = new System.Windows.Forms.TextBox();
            this.btn_nvo_arreglo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_cantidad_datos
            // 
            this.txt_cantidad_datos.Location = new System.Drawing.Point(151, 78);
            this.txt_cantidad_datos.Name = "txt_cantidad_datos";
            this.txt_cantidad_datos.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad_datos.TabIndex = 3;
            this.txt_cantidad_datos.Text = "5";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(15, 52);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(15, 75);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 2;
            this.btn_mostrar.Text = "mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // txt_datos
            // 
            this.txt_datos.Location = new System.Drawing.Point(15, 25);
            this.txt_datos.Name = "txt_datos";
            this.txt_datos.Size = new System.Drawing.Size(100, 20);
            this.txt_datos.TabIndex = 0;
            // 
            // btn_nvo_arreglo
            // 
            this.btn_nvo_arreglo.Location = new System.Drawing.Point(151, 98);
            this.btn_nvo_arreglo.Name = "btn_nvo_arreglo";
            this.btn_nvo_arreglo.Size = new System.Drawing.Size(75, 37);
            this.btn_nvo_arreglo.TabIndex = 4;
            this.btn_nvo_arreglo.Text = "nuevo arreglo";
            this.btn_nvo_arreglo.UseVisualStyleBackColor = true;
            this.btn_nvo_arreglo.Click += new System.EventHandler(this.btn_nvo_arreglo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 140);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nvo_arreglo);
            this.Controls.Add(this.txt_datos);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_cantidad_datos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cantidad_datos;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.TextBox txt_datos;
        private System.Windows.Forms.Button btn_nvo_arreglo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

