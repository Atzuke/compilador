
namespace compilador
{
    partial class FormPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Compilador = new System.Windows.Forms.TabPage();
            this.txtbLineas = new System.Windows.Forms.TextBox();
            this.txtbEditor = new System.Windows.Forms.TextBox();
            this.txtbProcesado = new System.Windows.Forms.TextBox();
            this.lblTextoRuta = new System.Windows.Forms.Label();
            this.lblRutaArchivo = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.cbEditor = new System.Windows.Forms.CheckBox();
            this.cbArchivo = new System.Windows.Forms.CheckBox();
            this.lblIngresoInfo = new System.Windows.Forms.Label();
            this.Tablas = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDummys = new System.Windows.Forms.TextBox();
            this.txtReservadas = new System.Windows.Forms.TextBox();
            this.txtLiterales = new System.Windows.Forms.TextBox();
            this.txtSimbolos = new System.Windows.Forms.TextBox();
            this.TablaErrores = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtSemanticos = new System.Windows.Forms.TextBox();
            this.txtLexicos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSintacticos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Compilador.SuspendLayout();
            this.Tablas.SuspendLayout();
            this.TablaErrores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Compilador);
            this.tabControl1.Controls.Add(this.Tablas);
            this.tabControl1.Controls.Add(this.TablaErrores);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1660, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // Compilador
            // 
            this.Compilador.Controls.Add(this.txtbLineas);
            this.Compilador.Controls.Add(this.txtbEditor);
            this.Compilador.Controls.Add(this.txtbProcesado);
            this.Compilador.Controls.Add(this.lblTextoRuta);
            this.Compilador.Controls.Add(this.lblRutaArchivo);
            this.Compilador.Controls.Add(this.btnProcesar);
            this.Compilador.Controls.Add(this.cbEditor);
            this.Compilador.Controls.Add(this.cbArchivo);
            this.Compilador.Controls.Add(this.lblIngresoInfo);
            this.Compilador.Location = new System.Drawing.Point(4, 25);
            this.Compilador.Name = "Compilador";
            this.Compilador.Padding = new System.Windows.Forms.Padding(3);
            this.Compilador.Size = new System.Drawing.Size(1652, 569);
            this.Compilador.TabIndex = 0;
            this.Compilador.Text = "Compilador";
            this.Compilador.UseVisualStyleBackColor = true;
            // 
            // txtbLineas
            // 
            this.txtbLineas.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtbLineas.Location = new System.Drawing.Point(182, 361);
            this.txtbLineas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbLineas.Multiline = true;
            this.txtbLineas.Name = "txtbLineas";
            this.txtbLineas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbLineas.Size = new System.Drawing.Size(10, 10);
            this.txtbLineas.TabIndex = 17;
            this.txtbLineas.Visible = false;
            // 
            // txtbEditor
            // 
            this.txtbEditor.BackColor = System.Drawing.Color.Black;
            this.txtbEditor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEditor.ForeColor = System.Drawing.Color.White;
            this.txtbEditor.Location = new System.Drawing.Point(210, 38);
            this.txtbEditor.Margin = new System.Windows.Forms.Padding(4);
            this.txtbEditor.Multiline = true;
            this.txtbEditor.Name = "txtbEditor";
            this.txtbEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbEditor.Size = new System.Drawing.Size(812, 250);
            this.txtbEditor.TabIndex = 16;
            this.txtbEditor.Visible = false;
            // 
            // txtbProcesado
            // 
            this.txtbProcesado.BackColor = System.Drawing.Color.Black;
            this.txtbProcesado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbProcesado.ForeColor = System.Drawing.Color.White;
            this.txtbProcesado.Location = new System.Drawing.Point(210, 361);
            this.txtbProcesado.Margin = new System.Windows.Forms.Padding(4);
            this.txtbProcesado.Multiline = true;
            this.txtbProcesado.Name = "txtbProcesado";
            this.txtbProcesado.ReadOnly = true;
            this.txtbProcesado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbProcesado.Size = new System.Drawing.Size(812, 190);
            this.txtbProcesado.TabIndex = 15;
            // 
            // lblTextoRuta
            // 
            this.lblTextoRuta.AutoSize = true;
            this.lblTextoRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoRuta.Location = new System.Drawing.Point(266, 103);
            this.lblTextoRuta.Name = "lblTextoRuta";
            this.lblTextoRuta.Size = new System.Drawing.Size(70, 26);
            this.lblTextoRuta.TabIndex = 14;
            this.lblTextoRuta.Text = "Ruta: ";
            // 
            // lblRutaArchivo
            // 
            this.lblRutaArchivo.AutoSize = true;
            this.lblRutaArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaArchivo.Location = new System.Drawing.Point(349, 103);
            this.lblRutaArchivo.Name = "lblRutaArchivo";
            this.lblRutaArchivo.Size = new System.Drawing.Size(58, 26);
            this.lblRutaArchivo.TabIndex = 13;
            this.lblRutaArchivo.Text = "Ruta";
            this.lblRutaArchivo.Visible = false;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Enabled = false;
            this.btnProcesar.Location = new System.Drawing.Point(563, 310);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(107, 30);
            this.btnProcesar.TabIndex = 12;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // cbEditor
            // 
            this.cbEditor.AutoSize = true;
            this.cbEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEditor.Location = new System.Drawing.Point(747, 5);
            this.cbEditor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEditor.Name = "cbEditor";
            this.cbEditor.Size = new System.Drawing.Size(174, 30);
            this.cbEditor.TabIndex = 11;
            this.cbEditor.Text = "Editor de texto";
            this.cbEditor.UseVisualStyleBackColor = true;
            this.cbEditor.CheckedChanged += new System.EventHandler(this.cbEditor_CheckedChanged);
            // 
            // cbArchivo
            // 
            this.cbArchivo.AutoSize = true;
            this.cbArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArchivo.Location = new System.Drawing.Point(611, 5);
            this.cbArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbArchivo.Name = "cbArchivo";
            this.cbArchivo.Size = new System.Drawing.Size(107, 30);
            this.cbArchivo.TabIndex = 10;
            this.cbArchivo.Text = "Archivo";
            this.cbArchivo.UseVisualStyleBackColor = true;
            this.cbArchivo.CheckedChanged += new System.EventHandler(this.cbArchivo_CheckedChanged);
            // 
            // lblIngresoInfo
            // 
            this.lblIngresoInfo.AutoSize = true;
            this.lblIngresoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresoInfo.Location = new System.Drawing.Point(235, 5);
            this.lblIngresoInfo.Name = "lblIngresoInfo";
            this.lblIngresoInfo.Size = new System.Drawing.Size(316, 26);
            this.lblIngresoInfo.TabIndex = 9;
            this.lblIngresoInfo.Text = "Tipo de Ingreso de información:";
            // 
            // Tablas
            // 
            this.Tablas.Controls.Add(this.label4);
            this.Tablas.Controls.Add(this.label3);
            this.Tablas.Controls.Add(this.label2);
            this.Tablas.Controls.Add(this.label1);
            this.Tablas.Controls.Add(this.txtDummys);
            this.Tablas.Controls.Add(this.txtReservadas);
            this.Tablas.Controls.Add(this.txtLiterales);
            this.Tablas.Controls.Add(this.txtSimbolos);
            this.Tablas.Location = new System.Drawing.Point(4, 25);
            this.Tablas.Name = "Tablas";
            this.Tablas.Padding = new System.Windows.Forms.Padding(3);
            this.Tablas.Size = new System.Drawing.Size(1652, 569);
            this.Tablas.TabIndex = 1;
            this.Tablas.Text = "Tablas de componentes lexico";
            this.Tablas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1224, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tabla de dummys";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tabla de palabras reservadas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tabla de simbolos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tabla de literales";
            // 
            // txtDummys
            // 
            this.txtDummys.BackColor = System.Drawing.Color.Black;
            this.txtDummys.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDummys.ForeColor = System.Drawing.Color.White;
            this.txtDummys.Location = new System.Drawing.Point(1227, 50);
            this.txtDummys.Margin = new System.Windows.Forms.Padding(4);
            this.txtDummys.Multiline = true;
            this.txtDummys.Name = "txtDummys";
            this.txtDummys.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDummys.Size = new System.Drawing.Size(398, 512);
            this.txtDummys.TabIndex = 13;
            // 
            // txtReservadas
            // 
            this.txtReservadas.BackColor = System.Drawing.Color.Black;
            this.txtReservadas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservadas.ForeColor = System.Drawing.Color.White;
            this.txtReservadas.Location = new System.Drawing.Point(821, 50);
            this.txtReservadas.Margin = new System.Windows.Forms.Padding(4);
            this.txtReservadas.Multiline = true;
            this.txtReservadas.Name = "txtReservadas";
            this.txtReservadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReservadas.Size = new System.Drawing.Size(398, 512);
            this.txtReservadas.TabIndex = 12;
            // 
            // txtLiterales
            // 
            this.txtLiterales.BackColor = System.Drawing.Color.Black;
            this.txtLiterales.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiterales.ForeColor = System.Drawing.Color.White;
            this.txtLiterales.Location = new System.Drawing.Point(415, 50);
            this.txtLiterales.Margin = new System.Windows.Forms.Padding(4);
            this.txtLiterales.Multiline = true;
            this.txtLiterales.Name = "txtLiterales";
            this.txtLiterales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLiterales.Size = new System.Drawing.Size(398, 512);
            this.txtLiterales.TabIndex = 11;
            // 
            // txtSimbolos
            // 
            this.txtSimbolos.BackColor = System.Drawing.Color.Black;
            this.txtSimbolos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSimbolos.ForeColor = System.Drawing.Color.White;
            this.txtSimbolos.Location = new System.Drawing.Point(9, 48);
            this.txtSimbolos.Margin = new System.Windows.Forms.Padding(4);
            this.txtSimbolos.Multiline = true;
            this.txtSimbolos.Name = "txtSimbolos";
            this.txtSimbolos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSimbolos.Size = new System.Drawing.Size(398, 512);
            this.txtSimbolos.TabIndex = 10;
            // 
            // TablaErrores
            // 
            this.TablaErrores.Controls.Add(this.label7);
            this.TablaErrores.Controls.Add(this.txtSintacticos);
            this.TablaErrores.Controls.Add(this.label6);
            this.TablaErrores.Controls.Add(this.label5);
            this.TablaErrores.Controls.Add(this.txtLexicos);
            this.TablaErrores.Controls.Add(this.txtSemanticos);
            this.TablaErrores.Location = new System.Drawing.Point(4, 25);
            this.TablaErrores.Name = "TablaErrores";
            this.TablaErrores.Padding = new System.Windows.Forms.Padding(3);
            this.TablaErrores.Size = new System.Drawing.Size(1652, 569);
            this.TablaErrores.TabIndex = 2;
            this.TablaErrores.Text = "Tabla de errores";
            this.TablaErrores.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSemanticos
            // 
            this.txtSemanticos.BackColor = System.Drawing.Color.Black;
            this.txtSemanticos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemanticos.ForeColor = System.Drawing.Color.White;
            this.txtSemanticos.Location = new System.Drawing.Point(464, 48);
            this.txtSemanticos.Margin = new System.Windows.Forms.Padding(4);
            this.txtSemanticos.Multiline = true;
            this.txtSemanticos.Name = "txtSemanticos";
            this.txtSemanticos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSemanticos.Size = new System.Drawing.Size(398, 512);
            this.txtSemanticos.TabIndex = 11;
            // 
            // txtLexicos
            // 
            this.txtLexicos.BackColor = System.Drawing.Color.Black;
            this.txtLexicos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLexicos.ForeColor = System.Drawing.Color.White;
            this.txtLexicos.Location = new System.Drawing.Point(32, 48);
            this.txtLexicos.Margin = new System.Windows.Forms.Padding(4);
            this.txtLexicos.Multiline = true;
            this.txtLexicos.Name = "txtLexicos";
            this.txtLexicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLexicos.Size = new System.Drawing.Size(398, 512);
            this.txtLexicos.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(893, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Errores Sintacticos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Errores Semanticos";
            // 
            // txtSintacticos
            // 
            this.txtSintacticos.BackColor = System.Drawing.Color.Black;
            this.txtSintacticos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSintacticos.ForeColor = System.Drawing.Color.White;
            this.txtSintacticos.Location = new System.Drawing.Point(896, 48);
            this.txtSintacticos.Margin = new System.Windows.Forms.Padding(4);
            this.txtSintacticos.Multiline = true;
            this.txtSintacticos.Name = "txtSintacticos";
            this.txtSintacticos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSintacticos.Size = new System.Drawing.Size(398, 512);
            this.txtSintacticos.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Errores Lexicos";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 598);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.tabControl1.ResumeLayout(false);
            this.Compilador.ResumeLayout(false);
            this.Compilador.PerformLayout();
            this.Tablas.ResumeLayout(false);
            this.Tablas.PerformLayout();
            this.TablaErrores.ResumeLayout(false);
            this.TablaErrores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Compilador;
        private System.Windows.Forms.TabPage Tablas;
        private System.Windows.Forms.TabPage TablaErrores;
        private System.Windows.Forms.TextBox txtbLineas;
        private System.Windows.Forms.TextBox txtbEditor;
        private System.Windows.Forms.TextBox txtbProcesado;
        private System.Windows.Forms.Label lblTextoRuta;
        private System.Windows.Forms.Label lblRutaArchivo;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.CheckBox cbEditor;
        private System.Windows.Forms.CheckBox cbArchivo;
        private System.Windows.Forms.Label lblIngresoInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtSimbolos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDummys;
        private System.Windows.Forms.TextBox txtReservadas;
        private System.Windows.Forms.TextBox txtLiterales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSintacticos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLexicos;
        private System.Windows.Forms.TextBox txtSemanticos;
    }
}