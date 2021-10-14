
namespace compilador
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
            this.lblIngresoInfo = new System.Windows.Forms.Label();
            this.cbArchivo = new System.Windows.Forms.CheckBox();
            this.cbEditor = new System.Windows.Forms.CheckBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRutaArchivo = new System.Windows.Forms.Label();
            this.lblTextoRuta = new System.Windows.Forms.Label();
            this.txtbProcesado = new System.Windows.Forms.TextBox();
            this.txtbEditor = new System.Windows.Forms.TextBox();
            this.txtAnaLex = new System.Windows.Forms.TextBox();
            this.txtbLineas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIngresoInfo
            // 
            this.lblIngresoInfo.AutoSize = true;
            this.lblIngresoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoInfo.Location = new System.Drawing.Point(65, 26);
            this.lblIngresoInfo.Name = "lblIngresoInfo";
            this.lblIngresoInfo.Size = new System.Drawing.Size(316, 26);
            this.lblIngresoInfo.TabIndex = 0;
            this.lblIngresoInfo.Text = "Tipo de Ingreso de información:";
            this.lblIngresoInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbArchivo
            // 
            this.cbArchivo.AutoSize = true;
            this.cbArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArchivo.Location = new System.Drawing.Point(441, 26);
            this.cbArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbArchivo.Name = "cbArchivo";
            this.cbArchivo.Size = new System.Drawing.Size(107, 30);
            this.cbArchivo.TabIndex = 1;
            this.cbArchivo.Text = "Archivo";
            this.cbArchivo.UseVisualStyleBackColor = true;
            this.cbArchivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbEditor
            // 
            this.cbEditor.AutoSize = true;
            this.cbEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditor.Location = new System.Drawing.Point(577, 26);
            this.cbEditor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEditor.Name = "cbEditor";
            this.cbEditor.Size = new System.Drawing.Size(174, 30);
            this.cbEditor.TabIndex = 2;
            this.cbEditor.Text = "Editor de texto";
            this.cbEditor.UseVisualStyleBackColor = true;
            this.cbEditor.CheckedChanged += new System.EventHandler(this.cbEditor_CheckedChanged);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Enabled = false;
            this.btnProcesar.Location = new System.Drawing.Point(393, 331);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(107, 30);
            this.btnProcesar.TabIndex = 3;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "archivo";
            // 
            // lblRutaArchivo
            // 
            this.lblRutaArchivo.AutoSize = true;
            this.lblRutaArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaArchivo.Location = new System.Drawing.Point(179, 124);
            this.lblRutaArchivo.Name = "lblRutaArchivo";
            this.lblRutaArchivo.Size = new System.Drawing.Size(58, 26);
            this.lblRutaArchivo.TabIndex = 4;
            this.lblRutaArchivo.Text = "Ruta";
            this.lblRutaArchivo.Visible = false;
            this.lblRutaArchivo.Click += new System.EventHandler(this.lblRutaArchivo_Click);
            // 
            // lblTextoRuta
            // 
            this.lblTextoRuta.AutoSize = true;
            this.lblTextoRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoRuta.Location = new System.Drawing.Point(96, 124);
            this.lblTextoRuta.Name = "lblTextoRuta";
            this.lblTextoRuta.Size = new System.Drawing.Size(70, 26);
            this.lblTextoRuta.TabIndex = 5;
            this.lblTextoRuta.Text = "Ruta: ";
            this.lblTextoRuta.Click += new System.EventHandler(this.lblRuta_Click);
            // 
            // txtbProcesado
            // 
            this.txtbProcesado.BackColor = System.Drawing.Color.Black;
            this.txtbProcesado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbProcesado.ForeColor = System.Drawing.Color.White;
            this.txtbProcesado.Location = new System.Drawing.Point(40, 382);
            this.txtbProcesado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbProcesado.Multiline = true;
            this.txtbProcesado.Name = "txtbProcesado";
            this.txtbProcesado.ReadOnly = true;
            this.txtbProcesado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbProcesado.Size = new System.Drawing.Size(812, 190);
            this.txtbProcesado.TabIndex = 6;
            this.txtbProcesado.TextChanged += new System.EventHandler(this.txtbProcesado_TextChanged);
            // 
            // txtbEditor
            // 
            this.txtbEditor.BackColor = System.Drawing.Color.Black;
            this.txtbEditor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEditor.ForeColor = System.Drawing.Color.White;
            this.txtbEditor.Location = new System.Drawing.Point(40, 59);
            this.txtbEditor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbEditor.Multiline = true;
            this.txtbEditor.Name = "txtbEditor";
            this.txtbEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbEditor.Size = new System.Drawing.Size(812, 250);
            this.txtbEditor.TabIndex = 7;
            this.txtbEditor.Visible = false;
            this.txtbEditor.TextChanged += new System.EventHandler(this.txtbEditor_TextChanged);
            // 
            // txtAnaLex
            // 
            this.txtAnaLex.BackColor = System.Drawing.Color.Black;
            this.txtAnaLex.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnaLex.ForeColor = System.Drawing.Color.White;
            this.txtAnaLex.Location = new System.Drawing.Point(861, 59);
            this.txtAnaLex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnaLex.Multiline = true;
            this.txtAnaLex.Name = "txtAnaLex";
            this.txtAnaLex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAnaLex.Size = new System.Drawing.Size(673, 512);
            this.txtAnaLex.TabIndex = 9;
            this.txtAnaLex.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbLineas
            // 
            this.txtbLineas.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtbLineas.Location = new System.Drawing.Point(12, 382);
            this.txtbLineas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbLineas.Multiline = true;
            this.txtbLineas.Name = "txtbLineas";
            this.txtbLineas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbLineas.Size = new System.Drawing.Size(10, 10);
            this.txtbLineas.TabIndex = 8;
            this.txtbLineas.Visible = false;
            this.txtbLineas.TextChanged += new System.EventHandler(this.txtbLineas_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 601);
            this.Controls.Add(this.txtAnaLex);
            this.Controls.Add(this.txtbLineas);
            this.Controls.Add(this.txtbEditor);
            this.Controls.Add(this.txtbProcesado);
            this.Controls.Add(this.lblTextoRuta);
            this.Controls.Add(this.lblRutaArchivo);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.cbEditor);
            this.Controls.Add(this.cbArchivo);
            this.Controls.Add(this.lblIngresoInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresoInfo;
        private System.Windows.Forms.CheckBox cbArchivo;
        private System.Windows.Forms.CheckBox cbEditor;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRutaArchivo;
        private System.Windows.Forms.Label lblTextoRuta;
        private System.Windows.Forms.TextBox txtbProcesado;
        private System.Windows.Forms.TextBox txtbEditor;
        private System.Windows.Forms.TextBox txtAnaLex;
        private System.Windows.Forms.TextBox txtbLineas;
    }
}

