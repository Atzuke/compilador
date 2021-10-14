using compilador.AnalisisLexico;
using compilador.ManejadorErrores;
using compilador.TablaSimbolos;
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

namespace compilador
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }



        private void btnProcesar_Click(object sender, EventArgs e)
        {
            String LexemaTipoAuxLiteral = "";
            String LexemaTipoAuxSimbolo = "";
            String LexemaTipoAuxReservada = "";
            String LexemaTipoAuxDummy = "";
            String LexemaTipo = "";

            String ErroresLexicos = "";
            String ErroresSemanticos = "";
            String ErroresSintacticos = "";
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
               


                



                try
                {
                    AnalizadorLexico AnaLex = new AnalizadorLexico();
                    ComponenteLexico Componente = AnaLex.DevolverComponenteLexico();
                    while (!Categoria.FIN_ARCHIVO.Equals(Componente.ObtenerCategoria()))
                    {
                        Componente = AnaLex.DevolverComponenteLexico();
                        


                    }
                }
                catch(Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message);
                }

           
                List<ComponenteLexico> ComponentesTipoLiteral = Tabla.ObtenerInstancia().ObtenerComponentes(Tipo.LITERAL);
                foreach (ComponenteLexico componenteLiteral in ComponentesTipoLiteral)
                {
                    MessageBox.Show(componenteLiteral.Mostrar());
                    LexemaTipo = componenteLiteral.Mostrar();
                    LexemaTipoAuxLiteral = "\n" + LexemaTipoAuxLiteral + "\n"+ LexemaTipo;


                }

                List<ComponenteLexico> ComponentesTipoSimbolo = Tabla.ObtenerInstancia().ObtenerComponentes(Tipo.SIMBOLO);
                foreach (ComponenteLexico componenteSimbolo in ComponentesTipoSimbolo)
                {
                    MessageBox.Show(componenteSimbolo.Mostrar());
                    LexemaTipo = componenteSimbolo.Mostrar();
                    LexemaTipoAuxSimbolo = "\n" + LexemaTipoAuxSimbolo + "\n" + LexemaTipo;


                }

                List<ComponenteLexico> ComponentesTipoReservada = Tabla.ObtenerInstancia().ObtenerComponentes(Tipo.PALABRA_RESERVADA);
                foreach (ComponenteLexico componenteReservada in ComponentesTipoReservada)
                {
                    MessageBox.Show(componenteReservada.Mostrar());
                    LexemaTipo = componenteReservada.Mostrar();
                    LexemaTipoAuxReservada = "\n" + LexemaTipoAuxReservada + "\n" + LexemaTipo;


                }
                

                List<ComponenteLexico> ComponentesTipoDummy = Tabla.ObtenerInstancia().ObtenerComponentes(Tipo.DUMMY);
                foreach (ComponenteLexico componenteDummy in ComponentesTipoDummy)
                {
                    MessageBox.Show(componenteDummy.Mostrar());
                    LexemaTipo = componenteDummy.Mostrar();
                    LexemaTipoAuxDummy = "\n" + LexemaTipoAuxDummy + "\n" + LexemaTipo;


                }

                List<Error> ErroresTipoLexico = GestorErrores.ObtenerInstancia().ObtenerErrores(TipoError.LEXICO);
                foreach (Error errorLexico in ErroresTipoLexico)
                {
                    MessageBox.Show(errorLexico.Mostrar());
                    LexemaTipo = errorLexico.Mostrar();
                    ErroresLexicos = "\n" + ErroresLexicos + "\n" + LexemaTipo;

                }

                Tabla.ObtenerInstancia().Limpiar(Tipo.LITERAL);
                Tabla.ObtenerInstancia().Limpiar(Tipo.SIMBOLO);
                Tabla.ObtenerInstancia().Limpiar(Tipo.PALABRA_RESERVADA);
                Tabla.ObtenerInstancia().Limpiar(Tipo.DUMMY);
                GestorErrores.ObtenerInstancia().Limpiar();



                txtLiterales.Text = LexemaTipoAuxLiteral;
                txtSimbolos.Text = LexemaTipoAuxSimbolo;
                txtReservadas.Text = LexemaTipoAuxReservada;
                txtDummys.Text = LexemaTipoAuxDummy;

                txtLexicos.Text = ErroresLexicos;
                txtSemanticos.Text = ErroresSemanticos;
                txtSintacticos.Text = ErroresSintacticos;

                txtbProcesado.Text = texto;
                

                int numeroLineas = txtbEditor.Lines.Count();
                //escribirLineas(numeroLineas);
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
                    contadorDeLineaImprimir = contadorDeLinea + 1;
                    texto = texto + contadorDeLineaImprimir + " " + txtbEditor.Lines[contador] + Environment.NewLine;
                    contador++;
                    contadorDeLinea++;
                }

               

                try
                {
                    AnalizadorLexico AnaLex = new AnalizadorLexico();
                    ComponenteLexico Componente = AnaLex.DevolverComponenteLexico();
                    while (!Categoria.FIN_ARCHIVO.Equals(Componente.ObtenerCategoria()))
                    {
                        Componente = AnaLex.DevolverComponenteLexico();
              
                    }
                }
                catch (Exception excepcion)
                {
                    MessageBox.Show(excepcion.Message);
                }

               
                List<ComponenteLexico> ComponentesTipoLiteral = Tabla.ObtenerInstancia().ObtenerComponentes(Tipo.LITERAL);
                foreach (ComponenteLexico componenteLiteral in ComponentesTipoLiteral)
                {
                    MessageBox.Show(componenteLiteral.Mostrar());
                    LexemaTipo = componenteLiteral.Mostrar();
                    LexemaTipoAuxLiteral = "\n" + LexemaTipoAuxLiteral + "\n" + LexemaTipo;


                }

                List<ComponenteLexico> ComponentesTipoSimbolo = Tabla.ObtenerInstancia().ObtenerComponentes(Tipo.SIMBOLO);
                foreach (ComponenteLexico componenteSimbolo in ComponentesTipoSimbolo)
                {
                    MessageBox.Show(componenteSimbolo.Mostrar());
                    LexemaTipo = componenteSimbolo.Mostrar();
                    LexemaTipoAuxSimbolo = "\n" + LexemaTipoAuxSimbolo + "\n" + LexemaTipo;


                }

                List<ComponenteLexico> ComponentesTipoReservada = Tabla.ObtenerInstancia().ObtenerComponentes(Tipo.PALABRA_RESERVADA);
                foreach (ComponenteLexico componenteReservada in ComponentesTipoReservada)
                {
                    MessageBox.Show(componenteReservada.Mostrar());
                    LexemaTipo = componenteReservada.Mostrar();
                    LexemaTipoAuxReservada = "\n" + LexemaTipoAuxReservada + "\n" + LexemaTipo;


                }


                List<ComponenteLexico> ComponentesTipoDummy = Tabla.ObtenerInstancia().ObtenerComponentes(Tipo.DUMMY);
                foreach (ComponenteLexico componenteDummy in ComponentesTipoDummy)
                {
                    MessageBox.Show(componenteDummy.Mostrar());
                    LexemaTipo = componenteDummy.Mostrar();
                    LexemaTipoAuxDummy = "\n" + LexemaTipoAuxDummy + "\n" + LexemaTipo;


                }

                List<Error> ErroresTipoLexico = GestorErrores.ObtenerInstancia().ObtenerErrores(TipoError.LEXICO);
                foreach (Error errorLexico in ErroresTipoLexico)
                {
                    MessageBox.Show(errorLexico.Mostrar());
                    LexemaTipo = errorLexico.Mostrar();
                    ErroresLexicos = "\n" + ErroresLexicos + "\n" + LexemaTipo;

                }
                Tabla.ObtenerInstancia().Limpiar(Tipo.LITERAL);
                Tabla.ObtenerInstancia().Limpiar(Tipo.SIMBOLO);
                Tabla.ObtenerInstancia().Limpiar(Tipo.PALABRA_RESERVADA);
                Tabla.ObtenerInstancia().Limpiar(Tipo.DUMMY);
                GestorErrores.ObtenerInstancia().Limpiar();

                txtLiterales.Text = LexemaTipoAuxLiteral;
                txtSimbolos.Text = LexemaTipoAuxSimbolo;
                txtReservadas.Text = LexemaTipoAuxReservada;
                txtDummys.Text = LexemaTipoAuxDummy;

                txtLexicos.Text = ErroresLexicos;
                txtSemanticos.Text = ErroresSemanticos;
                txtSintacticos.Text = ErroresSintacticos;

                txtbProcesado.Text = texto;

                int numeroLineas = txtbEditor.Lines.Count();
                //escribirLineas(numeroLineas);
                Cache.ObtenerCache().ReiniciarCache();
            }
        }

        private void cbArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbArchivo.Checked == true)
            {
                cbEditor.CheckState = 0;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
