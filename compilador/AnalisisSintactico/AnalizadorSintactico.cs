using compilador.AnalisisLexico;
using compilador.ManejadorErrores;
using compilador.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compilador.AnalisisSintactico
{
    public class AnalizadorSintactico
    {
        private AnalizadorLexico anaLex = new AnalizadorLexico();
        private ComponenteLexico componente;
        public void Analizar()
        {
            Avanzar();
            Expresion();
            
            if (GestorErrores.ObtenerInstancia().HayErrores())
            {
                MessageBox.Show("La compilación ha finalizado pero hay errores en el programa de entrada. Por favor verifique la consola de errores"); 
            }
            else if (Categoria.FIN_ARCHIVO.Equals(componente.ObtenerCategoria()))
            {
                MessageBox.Show("La compilación ha finalizado exitosamente...");
            }
            else
            {
                MessageBox.Show("Aunque la compilación ha finalizado exitosamente, faltaron componentes por evaluar");
            }
        }
        private void Avanzar()
        {
            componente = anaLex.DevolverComponenteLexico();
        }
        private void Expresion()
        {
            Termino();
            ExpresionPrima();

        }
        private void ExpresionPrima()
        {
            if (Categoria.SUMA.Equals(componente.ObtenerCategoria()))
            {
                Avanzar();
                Expresion();
            }
            else if (Categoria.RESTA.Equals(componente.ObtenerCategoria()))
            {
                Avanzar();
                Expresion();
            }

        }
        private void Termino()
        {
            Factor();
            TerminoPrima();

        }
        private void TerminoPrima()
        {
            if (Categoria.MULTIPLICACION.Equals(componente.ObtenerCategoria()))
            {
                Avanzar();
                Termino();
            }
            else if (Categoria.DIVISION.Equals(componente.ObtenerCategoria()))
            {
                Avanzar();
                Termino();
            }
        }
        private void Factor()
        {
            if (Categoria.NUMERO_ENTERO.Equals(componente.ObtenerCategoria()))
            {
                Avanzar();  
            }
            else if (Categoria.NUMERO_DECIMAL.Equals(componente.ObtenerCategoria()))
            {
                Avanzar();
            }
            else if (Categoria.PARENTESIS_ABRE.Equals(componente.ObtenerCategoria()))
            {
                Avanzar();
                Expresion();

                if (Categoria.PARENTESIS_CIERRA.Equals(componente.ObtenerCategoria()))
                {
                    Avanzar();
                }
                else
                {
                    string Falla = "Componente no valido " + componente.ObtenerLexema();
                    string Causa = "Recibí " + componente.ObtenerCategoria() + " y esperaba ) (PARENTESIS_CIERRA)";
                    string Solucion = "Asegurse de que al ingresar un ( (PARENTESIS_ABRE), ingrese un ) (PARENTESIS_CIERRA) al finalizar";

                    Error Error = Error.Crear(componente.ObtenerNumeroLinea(), componente.ObtenerPosicionInicial(),
                        componente.ObtenerPosicionFinal(), Falla, Causa, Solucion, TipoError.SINTACTICO);
                    GestorErrores.ObtenerInstancia().Agregar(Error);
                }
            }
            else
            {
                string Falla = "Componente no valido " + componente.ObtenerLexema();
                string Causa = "Recibí " + componente.ObtenerCategoria() + " ...";
                string Solucion = "Asegurse que el componente que está en esta posición sea valido (Numeor entero, numeor decimal, parentecis abre)";

                Error Error = Error.Crear(componente.ObtenerNumeroLinea(), componente.ObtenerPosicionInicial(),
                    componente.ObtenerPosicionFinal(), Falla, Causa, Solucion, TipoError.SINTACTICO);
                GestorErrores.ObtenerInstancia().Agregar(Error);
                throw new Exception("Error tipo stopper durante analizis sintactico. Por favor verifique la consola de errores...");
            }
        }
    }
}
