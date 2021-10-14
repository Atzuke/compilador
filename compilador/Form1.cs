using compilador.AnalisisLexico;
using compilador.Transversal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using compilador.TablaSimbolos;

namespace compilador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbArchivo.Checked == true)
            {
                cbEditor.CheckState=0;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    lblRutaArchivo.Text = openFileDialog1.FileName;
                    lblRutaArchivo.Visible = true;
                }
                btnProcesar.Enabled = true;
            }
            else
            {
                btnProcesar.Enabled = false;
            }
        }
        private void cbEditor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditor.Checked == true)
            {
                cbArchivo.CheckState = 0;
                txtbEditor.Visible = true;
                btnProcesar.Enabled = true;
            }
            else
            {
                cbEditor.CheckState = 0;
                txtbEditor.Visible = false;
                btnProcesar.Enabled = false;
            }


        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

            if (cbArchivo.Checked == true)
            {
                int i = 1;
                string linea;
                string texto = "";
                StreamReader lector = new StreamReader(lblRutaArchivo.Text);
                linea = lector.ReadLine();
                while (linea != null)
                {
                    Cache.ObtenerCache().AgregarLinea(linea);
                    texto = texto + i + " " + linea + Environment.NewLine;
                    linea = lector.ReadLine();
                    i = i + 1; 
                }
                AnalizadorLexico AnaLex = new AnalizadorLexico();
                ComponenteLexico Componente = AnaLex.DevolverComponenteLexico();


                //List<ComponenteLexico> ComponentesSimbolos = new List<ComponenteLexico>();
                
                String LexemaTipoAux = "";
                String LexemaTipo = "";
                //Tabla tabla = Tabla.ObtenerInstancia();


                


                while (!Categoria.FIN_ARCHIVO.Equals(Componente.ObtenerCategoria()))
                {
                    Componente = AnaLex.DevolverComponenteLexico();
                    //List<ComponenteLexico> ComponentesLexAux = Tabla.ObtenerInstancia().ObtenerComponentes(Tipo.LITERAL);
                    

                }
                List<ComponenteLexico> ComponentesTipoLiteral = Tabla.ObtenerInstancia().ObtenerComponentes(Tipo.LITERAL);
                foreach (ComponenteLexico componenteSimbolo in ComponentesTipoLiteral)
                {
                    MessageBox.Show(componenteSimbolo.Mostrar());
                    LexemaTipo = componenteSimbolo.Mostrar();
                    LexemaTipoAux = LexemaTipoAux + LexemaTipo;
                    

                }

                /*
                  while (!Categoria.FIN_ARCHIVO.Equals(Componente.ObtenerCategoria()))
                  {

                      MessageBox.Show(Componente.ToString());
                      Componente = AnaLex.DevolverComponenteLexico();
                      Lexema2 = AnaLex.DevolverResultado();

                  }
                */

                txtAnaLex.Text = LexemaTipoAux;
                txtbProcesado.Text = texto;

                int numeroLineas = txtbEditor.Lines.Count();
                escribirLineas(numeroLineas);
                Cache.ObtenerCache().ReiniciarCache();
            }
            if (cbEditor.Checked == true)
            {
                btnProcesar.Enabled = true;

                int numeroDeLineas = txtbEditor.Lines.Length;
                int contadorDeLinea = 0;
                int contador = 0;
                string texto = "";
                int contadorDeLineaImprimir = 0;
                while (contadorDeLinea < numeroDeLineas)
                {
                    Cache.ObtenerCache().AgregarLinea(txtbEditor.Lines[contador]);
                    contadorDeLineaImprimir=contadorDeLinea+1;
                    texto = texto + contadorDeLineaImprimir + " " + txtbEditor.Lines[contador] + Environment.NewLine;
                    contador++;
                    contadorDeLinea++;
                }

                AnalizadorLexico AnaLex = new AnalizadorLexico();
                String Lexema = AnaLex.DevolverComponenteLexico().ObtenerLexema();
                String Lexema2 = AnaLex.DevolverResultado();
                while (!"@EOF@".Equals(Lexema))
                {
                    Lexema = AnaLex.DevolverComponenteLexico().ObtenerLexema();
                    Lexema2 = AnaLex.DevolverResultado();
                    txtAnaLex.Text = Lexema2;
                }
                txtbProcesado.Text = texto;

                int numeroLineas = txtbEditor.Lines.Count();
                escribirLineas(numeroLineas);
                txtbEditor.Text ="";
                Cache.ObtenerCache().ReiniciarCache();
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRutaArchivo_Click(object sender, EventArgs e)
        {

        }

        private void lblRuta_Click(object sender, EventArgs e)
        {

        }

        private void txtbProcesado_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void escribirLineas(int numeroLineas)
        {
            string linea = "";
            string texto = "";

            for (int i=1; i<=numeroLineas;i++)
            {
                linea = i.ToString();
                texto= texto + linea + Environment.NewLine;
            }
            txtbLineas.Text = texto;
        }

        private void txtbLineas_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtbEditor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
