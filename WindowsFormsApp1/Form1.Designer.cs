namespace ProyectoDescuentos
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
		/// Método necesario para admitir el Diseñador. 
		/// No se puede modificar el contenido de este método con el editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(150, 50);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(160, 22);
			this.txtNombre.TabIndex = 0;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(150, 100);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(160, 22);
			this.txtPrecio.TabIndex = 1;
			// 
			// cmbTipo
			// 
			this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Location = new System.Drawing.Point(150, 150);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(160, 24);
			this.cmbTipo.TabIndex = 2;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(150, 200);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(160, 30);
			this.btnCalcular.TabIndex = 3;
			this.btnCalcular.Text = "Calcular descuento";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(70, 53);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(59, 16);
			this.lblNombre.TabIndex = 4;
			this.lblNombre.Text = "Nombre:";
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Location = new System.Drawing.Point(70, 103);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(49, 16);
			this.lblPrecio.TabIndex = 5;
			this.lblPrecio.Text = "Precio:";
			// 
			// lblTipo
			// 
			this.lblTipo.AutoSize = true;
			this.lblTipo.Location = new System.Drawing.Point(70, 153);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(38, 16);
			this.lblTipo.TabIndex = 6;
			this.lblTipo.Text = "Tipo:";
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.lblResultado.Location = new System.Drawing.Point(150, 260);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(0, 18);
			this.lblResultado.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 320);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblTipo);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.cmbTipo);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtNombre);
			this.Name = "Form1";
			this.Text = "Calculadora de Descuentos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblResultado;
	}
}
