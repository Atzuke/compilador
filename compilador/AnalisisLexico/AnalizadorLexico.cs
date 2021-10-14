using compilador.TablaSimbolos;
using compilador.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using compilador.ManejadorErrores;

namespace compilador.AnalisisLexico
{
    class AnalizadorLexico
    {
        private int Puntero;
        private int NumeroLineaActual;
        private Linea LineaActual;
        private String CaracterActual;
        private String Lexema;
        private String ResultadoAnaLex;
        private int EstadoActual;
        private bool ContinuarAnalisis;
        private ComponenteLexico Componente;


        public AnalizadorLexico()
        {
            CargarNuevaLinea();
        }

        private void CargarNuevaLinea()
        {
            NumeroLineaActual = NumeroLineaActual + 1;
            LineaActual = Cache.ObtenerCache().ObtenerLinea(NumeroLineaActual);
            NumeroLineaActual = LineaActual.ObtenerNumero(); //Asegura que se quede en el fin de archivo
            Puntero = 0;

        }

        private void DevolverPuntero()
        {
            if (Puntero > 1)
            {
                Puntero = Puntero - 1;
            }
        }

        private void AvanzarPuntero()
        {
            Puntero = Puntero + 1;
        }

        private void LeerSiguienteCaracter()
        {
            if (LineaActual.esFinArchivo())
            {
                CaracterActual = LineaActual.ObtenerContenido();
            }
            else if (Puntero > LineaActual.ObtenerLongitud()-1)
            {
                Puntero = LineaActual.ObtenerLongitud() + 1;
                CaracterActual = "@FL@";
            }
            else
            {
                CaracterActual = LineaActual.ObtenerContenido().Substring(Puntero, 1); //oBTIENE LA PARTE DE LA CADENA DEL PUNTERO Y OBTIENE UN CARACTER
                AvanzarPuntero();
            }
        }

        public String DevolverResultado()
        {
            return ResultadoAnaLex; 
        }

        public void Reiniciar()
        {
            Lexema = "";
            CaracterActual = "";
            EstadoActual = 0;
            ContinuarAnalisis = true;
        }

        public void ReiniciarComentario()
        {
           
            EstadoActual = 34;
            ContinuarAnalisis = true;
        }

        private void FormarComponente(string Lexema, Categoria Categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal, Tipo Tipo)
        {

            Componente = ComponenteLexico.Crear(Lexema, Categoria, NumeroLinea, PosicionInicial, PosicionFinal, Tipo);
            Tabla.ObtenerInstancia().Agregar(Componente);

        }

        public ComponenteLexico DevolverComponenteLexico()
        {
            Reiniciar();
            while (ContinuarAnalisis)
            {
                switch (EstadoActual)
                {
                    case 0:
                        ProcesarEstado0();
                        break;
                    case 1:
                        ProcesarEstado1();
                        break;
                    case 2:
                        ProcesarEstado2();
                        break;
                    case 3:
                        ProcesarEstado3();
                        break;
                    case 4:
                        ProcesarEstado4();
                        break;
                    case 5:
                        ProcesarEstado5();
                        break;
                    case 6:
                        ProcesarEstado6();
                        break;
                    case 7:
                        ProcesarEstado7();
                        break;
                    case 8:
                        ProcesarEstado8();
                        break;
                    case 9:
                        ProcesarEstado9();
                        break;
                    case 10:
                        ProcesarEstado10();
                        break;
                    case 11:
                        ProcesarEstado11();
                        break;
                    case 12:
                        ProcesarEstado12();
                        break;
                    case 13:
                        ProcesarEstado13();
                        break;
                    case 14:
                        ProcesarEstado14();
                        break;
                    case 15:
                        ProcesarEstado15();
                        break;
                    case 16:
                        ProcesarEstado16();
                        break;
                    case 17:
                        ProcesarEstado17();
                        break;
                    case 18:
                        ProcesarEstado18();
                        break;
                    case 19:
                        ProcesarEstado19();
                        break;
                    case 20:
                        ProcesarEstado20();
                        break;
                    case 21:
                        ProcesarEstado21();
                        break;
                    case 22:
                        ProcesarEstado22();
                        break;
                    case 23:
                        ProcesarEstado23();
                        break;
                    case 24:
                        ProcesarEstado24();
                        break;
                    case 25:
                        ProcesarEstado25();
                        break;
                    case 26:
                        ProcesarEstado26();
                        break;
                    case 27:
                        ProcesarEstado27();
                        break;
                    case 28:
                        ProcesarEstado28();
                        break;
                    case 29:
                        ProcesarEstado29();
                        break;
                    case 30:
                        ProcesarEstado30();
                        break;
                    case 31:
                        ProcesarEstado31();
                        break;
                    case 32:
                        ProcesarEstado32();
                        break;
                    case 33:
                        ProcesarEstado33();
                        break;
                    case 34:
                        ProcesarEstado34();
                        break;
                    case 35:
                        ProcesarEstado35();
                        break;
                    case 36:
                        ProcesarEstado36();
                        break;
                    case 37:
                        ProcesarEstado37();
                        break;
                    case 38:
                        ProcesarEstado38();
                        break;
                    case 39:
                        ProcesarEstado39();
                        break;
                    case 40:
                        ProcesarEstado40();
                        break;
                    case 41:
                        ProcesarEstado41();
                        break;
                    case 42:
                        ProcesarEstado42();
                        break;
                    case 43:
                        ProcesarEstado43();
                        break;
                    case 44:
                        ProcesarEstado44();
                        break;
                    case 45:
                        ProcesarEstado45();
                        break;
                    case 46:
                        ProcesarEstado46();
                        break;
                    case 47:
                        ProcesarEstado47();
                        break;
                    case 48:
                        ProcesarEstado48();
                        break;
                    case 49:
                        ProcesarEstado49();
                        break;
                    case 50:
                        ProcesarEstado50();
                        break;
                    case 51:
                        ProcesarEstado51();
                        break;
                    case 52:
                        ProcesarEstado52();
                        break;
                    case 53:
                        ProcesarEstado53();
                        break;
                    case 54:
                        ProcesarEstado54();
                        break;
                    case 55:
                        ProcesarEstado55();
                        break;
                    case 56:
                        ProcesarEstado56();
                        break;
                    case 57:
                        ProcesarEstado57();
                        break;
                    case 58:
                        ProcesarEstado58();
                        break;
                    case 59:
                        ProcesarEstado59();
                        break;
                    case 60:
                        ProcesarEstado60();
                        break;
                    case 61:
                        ProcesarEstado61();
                        break;
                    case 62:
                        ProcesarEstado62();
                        break;
                    case 63:
                        ProcesarEstado63();
                        break;
                    case 64:
                        ProcesarEstado64();
                        break;
                    case 65:
                        ProcesarEstado65();
                        break;
                    case 66:
                        ProcesarEstado66();
                        break;
                }

            }
            return Componente;
        }

        private void ProcesarEstado0()
        {
            LeerSiguienteCaracter();
            DevorarEspacioBlanco();
            if(EsLetraF())
            {
                EstadoActual = 61;
                FormarLexema();
            }
            else if (EsLetraV())
            {
                EstadoActual = 47;
                FormarLexema();
            }
            else if (EsLetra() || EsGuionBajo() || EsSimboloPesos())
            {
                EstadoActual = 4;
                FormarLexema();
            }
            else if (EsDigito())
            {
                EstadoActual = 1;
                FormarLexema();
            }
            else if (EsSignoSuma())
            {
                EstadoActual = 5;
                FormarLexema();
            }
            else if (EsSignoResta())
            {
                EstadoActual = 6;
                FormarLexema();
            }
            else if (EsSignoMultiplicacion())
            {
                EstadoActual = 7;
                FormarLexema();
            }
            else if (EsSignoDivision())
            {
                EstadoActual = 8;
                FormarLexema();
            }
            else if (EsSignoModulo())
            {
                EstadoActual = 9;
                FormarLexema();
            }
            else if (EsParentesisAbre())
            {
                EstadoActual = 10;
                FormarLexema();
            }
            else if (EsParentesisCierra())
            {
                EstadoActual = 11;
                FormarLexema();
            }
            else if (LineaActual.esFinArchivo())
            {
                EstadoActual = 12;
                FormarLexema();
            }
            else if (EsSignoIgual())
            {
                EstadoActual = 19;
                FormarLexema();
            }
            else if (EsSignoMenor())
            {
                EstadoActual = 20;
                FormarLexema();
            }
            else if (EsSignoMayor())
            {
                EstadoActual = 21;
                FormarLexema();
            }
            else if (EsDosPuntos())
            {
                EstadoActual = 22;
                FormarLexema();
            }
            else if (EsSignoAdmiracion())
            {
                EstadoActual = 30;
                FormarLexema();
            }
            else if (EsComamillaDoble())
            {
                EstadoActual = 43;
                
            }
            else if (EsComamillaSimple())
            {
                EstadoActual = 38;
                
            }
            else if (EsFinLinea())
            {
                EstadoActual = 13;
            }
            else
            {
                EstadoActual = 18;
            }
        }

        private void ProcesarEstado1()
        {
            LeerSiguienteCaracter();

            if (EsDigito())
            {
                EstadoActual = 1;
                FormarLexema();
            }
            else if (EsComa())
            {
                EstadoActual = 2;
                FormarLexema();
            }
            else
            {
                EstadoActual = 14;
            }
        }

        private void ProcesarEstado2()
        {
            LeerSiguienteCaracter();

            if (EsDigito())
            {
                EstadoActual = 3;
                FormarLexema();
            }
            else
            {
                EstadoActual = 17;
            }

        }

        private void ProcesarEstado3()
        {
            LeerSiguienteCaracter();

            if (EsDigito())
            {
                EstadoActual = 3;
                FormarLexema();
            }
            else
            {
                EstadoActual = 15;
            }
        }

        private void ProcesarEstado4()
        {
            LeerSiguienteCaracter();

            if (EsLetra() || EsGuionBajo() || EsSimboloPesos() || EsDigito())
            {
                EstadoActual = 4;
                FormarLexema();
            }
            else
            {
                EstadoActual = 16;
            }
        }

        private void ProcesarEstado5()
        {
            //String Categoria = "SUMA";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.SUMA + "," + Lexema +")";
            FormarComponente(Lexema, Categoria.SUMA, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado6()
        {

            //String Categoria = "RESTA";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.RESTA + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.RESTA, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);
            

            ContinuarAnalisis = false;
        }

            

        private void ProcesarEstado7()
        {

            //String Categoria = "MULTIPLICACION";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "("+ Tipo.SIMBOLO+ "," + Categoria.MULTIPLICACION + "," + Lexema + ")" ;
            FormarComponente(Lexema, Categoria.MULTIPLICACION, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);
            

            ContinuarAnalisis = false;
        }
        private void ProcesarEstado8()
        {
            LeerSiguienteCaracter();
            if (EsSignoMultiplicacion())
            {
                EstadoActual = 34;
                FormarLexema();
            }
            else if (EsSignoDivision())
            {
                EstadoActual = 36;
                FormarLexema();
            }
            else
            {
                EstadoActual = 33;
            }
        }

        private void ProcesarEstado9()
        {
            //String Categoria = "MODULO";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.MODULO + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.MODULO, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);
            

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado10()
        {
            //String Categoria = "PARENTESIS ABRE";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.PARENTESIS_ABRE + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.PARENTESIS_ABRE, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado11()
        {
            //String Categoria = "PARENTESIS CIERRA";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.PARENTESIS_CIERRA + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.PARENTESIS_CIERRA, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado12()
        {
            //String Categoria = "FIN DE ARCHIVO (EOF)";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.FIN_ARCHIVO + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.FIN_ARCHIVO, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado13()
        {
            CargarNuevaLinea();
            Reiniciar();
        }

        private void ProcesarEstado14()
        {
            DevolverPuntero();

            //String Categoria = "NUMERO ENTERO";
            
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.LITERAL + "," + Categoria.NUMERO_ENTERO + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.NUMERO_ENTERO, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.LITERAL);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado15()
        {
            DevolverPuntero();

            //String Categoria = "NUMERO DECIMAL";

            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.LITERAL + "," + Categoria.NUMERO_DECIMAL + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.NUMERO_DECIMAL, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.LITERAL);

            ContinuarAnalisis = false;
        }



        private void ProcesarEstado16()
        {
            DevolverPuntero();

            
            
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;
            

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.LITERAL + "," + Categoria.IDENTIFICADOR + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.IDENTIFICADOR, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.LITERAL);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado17()
        {
            DevolverPuntero();

            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero;


            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.LITERAL + "," + Categoria.IDENTIFICADOR + "," + Lexema + ")";

            FormarComponente(Lexema + "0", Categoria.NUMERO_DECIMAL, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.DUMMY);

            string Falla = "Numero decimal no valido: "+Lexema+CaracterActual;
            string Causa = "Recibí "+CaracterActual+" y esperaba digito de 0 a 9";
            string Solucion = "Asegurese que luego de la parte decimal aparezca un digito del 0 al 9";

            Error Error = Error.Crear(NumeroLineaActual, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);
            GestorErrores.ObtenerInstancia().Agregar(Error);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado18()
        {

            //
            int PosicionInicial = Puntero - 1;
            int PosicionFinal = Puntero - 1;
            //MessageBox.Show("Error en linea " + NumeroLinea + ": Símbolo " + "'" + CaracterActual + "'" + " no reconocido, no permitido");

            string Falla = "Simbolo no valido: "+ CaracterActual;
            string Causa = "Recibí " + CaracterActual + " el cual no es soportado";
            string Solucion = "Asegurese de que el simbolo sea aceptado por el lenguaje";

            Error Error = Error.Crear(NumeroLineaActual, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);
            GestorErrores.ObtenerInstancia().Agregar(Error);
            //throw new Exception("Se ha presentado un error que impide continuar con el análisis léxico..."); 
        }

        private void ProcesarEstado19()
        {
            //String Categoria = "IGUAL QUE";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.IGUAL_QUE + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.IGUAL_QUE, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado20()
        {
            LeerSiguienteCaracter();

            if (EsSignoMayor())
            {
                EstadoActual = 23;
                FormarLexema();
            }
            else if (EsSignoIgual())
            {
                EstadoActual = 24;
                FormarLexema();
            }
            else
            {
                EstadoActual = 25;
            }

        }

        private void ProcesarEstado21()
        {
            LeerSiguienteCaracter();

            if (EsSignoIgual())
            {
                EstadoActual = 26;
                FormarLexema();
            }
            else
            {
                EstadoActual = 27;

            }

        }

        private void ProcesarEstado22()
        {
            LeerSiguienteCaracter();

            if (EsSignoIgual())
            {
                EstadoActual = 28;
                FormarLexema();
            }
            else
            {
                EstadoActual = 29;

            }

        }

        private void ProcesarEstado23()
        {
            //String Categoria = "DIFERENTE QUE";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.DIFERENTE_QUE + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.DIFERENTE_QUE, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado24()
        {
            //String Categoria = "MENOR O IGUAL QUE";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.MENOR_IGUAL_QUE + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.MENOR_IGUAL_QUE, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado25()
        {
            DevolverPuntero();

            //String Categoria = "MENOR QUE";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.MENOR_QUE + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.MENOR_QUE, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado26()
        {
            //String Categoria = "MAYOR O IGUAL QUE";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);

            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.MAYOR_IGUAL_QUE + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.MAYOR_IGUAL_QUE, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado27()
        {
            DevolverPuntero();

            //String Categoria = "MAYOR QUE";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.MAYOR_QUE + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.MAYOR_QUE, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado28()
        {
            //String Categoria = "ASIGNACION";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.ASIGNACION + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.ASIGNACION, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado29()
        {
            DevolverPuntero();

            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero;


            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.DUMMY + "," + Categoria.ASIGNACION + "," + Lexema + ")";

            FormarComponente(Lexema + "=", Categoria.ASIGNACION, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.DUMMY);

            string Falla = "Operacion asignacion no valida: " + Lexema + CaracterActual;
            string Causa = "Recibí " + CaracterActual + " y esperaba signo =";
            string Solucion = "Asegurese que luego de los dos puntos siga el signo =";

            Error Error = Error.Crear(NumeroLineaActual, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);
            GestorErrores.ObtenerInstancia().Agregar(Error);
            ContinuarAnalisis = false;
        }

        private void ProcesarEstado30()
        {
            LeerSiguienteCaracter();

            if (EsSignoIgual())
            {
                EstadoActual = 31;
                FormarLexema();
            }
            else
            {
                EstadoActual = 32;

            }

        }

        private void ProcesarEstado31()
        {
            //String Categoria = "DIFERENTE QUE";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.DIFERENTE_QUE + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.DIFERENTE_QUE, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado32()
        {
            DevolverPuntero();

            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero;


            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.DUMMY + "," + Categoria.DIFERENTE_QUE + "," + Lexema + ")";

            FormarComponente(Lexema + "=", Categoria.DIFERENTE_QUE, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.DUMMY);

            string Falla = "Operacion desigualdad no valida: " + Lexema + CaracterActual;
            string Causa = "Recibí " + CaracterActual + " y esperaba signo =";
            string Solucion = "Asegurese que luego de ! siga el signo =";

            Error Error = Error.Crear(NumeroLineaActual, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);
            GestorErrores.ObtenerInstancia().Agregar(Error);
            ContinuarAnalisis = false;

        }

        private void ProcesarEstado33()
        {
            DevolverPuntero();

            //String Categoria = "DIVISION";
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.SIMBOLO + "," + Categoria.DIVISION + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.DIVISION, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);

            ContinuarAnalisis = false;
        }
        private void ProcesarEstado34()
        {
            LeerSiguienteCaracter();

            if (EsSignoMultiplicacion())
            {
                EstadoActual = 35;
            }
            else if (EsFinLinea())
            {
                EstadoActual = 37;
            }
        }

        private void ProcesarEstado35()
        {
            LeerSiguienteCaracter();

            if (EsSignoMultiplicacion())
            {
                EstadoActual = 35;
            }
            else if (!EsSignoMultiplicacion() && !EsSignoDivision())
            {
                EstadoActual = 34;

            }
            else if (EsSignoDivision())
            {
                EstadoActual = 0;
            }
            else if (EsFinLinea())
            {
                EstadoActual = 37;
            }
        }

        private void ProcesarEstado36()
        {
            LeerSiguienteCaracter();

            if (!EsFinLinea())
            {
                EstadoActual = 36;
            }
            else
            {
                EstadoActual = 13;
            }
        }


        private void ProcesarEstado37()
        {
            CargarNuevaLinea();
            ReiniciarComentario();
        }

        private void ProcesarEstado38()
        {
            LeerSiguienteCaracter();

            if (!EsComamillaSimple())
            {
                EstadoActual = 39;
                FormarLexema();
            }
            else
            {
                EstadoActual = 41;
            }

        }

        private void ProcesarEstado39()
        {
            LeerSiguienteCaracter();

            if (EsComamillaSimple())
            {
                EstadoActual = 40;
                
            }
            else
            {
                EstadoActual = 42;
            }

        }

        private void ProcesarEstado40()
        {
            //String Categoria = "CARACTER";
            int NumeroLinea = NumeroLineaActual;
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.LITERAL+ "," + Categoria.CARACTER + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.CARACTER, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.LITERAL);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado41()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;
            //MessageBox.Show("Error en linea " + NumeroLinea + ": Símbolo " + "'" + CaracterActual + "'" + " no reconocido, no permitido");

            string Falla = "Simbolo no valido: " + CaracterActual;
            string Causa = "Se esperaba un caracter antes de cerrar con '";
            string Solucion = "Asegurese de que el caracter sea valido para el sistema";

            Error Error = Error.Crear(NumeroLineaActual, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);
            GestorErrores.ObtenerInstancia().Agregar(Error);
            throw new Exception("Se ha presentado un error que impide continuar con el análisis léxico...");

        }
        private void ProcesarEstado42()
        {
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;
            //MessageBox.Show("Error en linea " + NumeroLinea + ": Símbolo " + "'" + CaracterActual + "'" + " no reconocido, no permitido");

            string Falla = "Simbolo no valido: " + CaracterActual;
            string Causa = "Se esperaba que el caracter se cerrara con '";
            string Solucion = "Asegurese de que el caracter se cierre con '";

            Error Error = Error.Crear(NumeroLineaActual, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);
            GestorErrores.ObtenerInstancia().Agregar(Error);
            throw new Exception("Se ha presentado un error que impide continuar con el análisis léxico...");

        }
        private void ProcesarEstado43()
        {
            LeerSiguienteCaracter();

            if (!EsComamillaDoble())
            {
                EstadoActual = 44;
                FormarLexema();
            }
            else
            {
                EstadoActual = 45;
            }

        }
        private void ProcesarEstado44()
        {
            LeerSiguienteCaracter();
            if (EsFinArchivo())
            {
                EstadoActual = 66;
                FormarLexema();
            }
            else if (!EsComamillaDoble())
            {
                EstadoActual = 44;
                FormarLexema();
            }
            else
            {
                EstadoActual = 45;
            }

        }
        private void ProcesarEstado45()
        {
            //String Categoria = "CADENA";
            int NumeroLinea = NumeroLineaActual;
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.LITERAL + "," + Categoria.CADENA + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.CADENA, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.LITERAL);

            ContinuarAnalisis = false;
        }

        //no se esta usando
        private void ProcesarEstado46()
        {
            int NumeroLinea = NumeroLineaActual;
            DevolverPuntero();
            //throw new Exception("Asignación diferencia no válida con el caracter:" + CaracterActual + ", No es permitida.");
            MessageBox.Show("Error en linea " + NumeroLinea + ": Se esperaba una cadena");
            ContinuarAnalisis = false;

        }
        private void ProcesarEstado47()
        {
            LeerSiguienteCaracter();

            if (EsLetraE())
            {
                EstadoActual = 48;
                FormarLexema();
            }
            else
            {
                EstadoActual = 4;
                FormarLexema();
            }

        }
        private void ProcesarEstado48()
        {
            LeerSiguienteCaracter();

            if (EsLetraR())
            {
                EstadoActual = 49;
                FormarLexema();
            }
            else
            {
                EstadoActual = 4;
                FormarLexema();
            }

        }
        private void ProcesarEstado49()
        {
            LeerSiguienteCaracter();

            if (EsLetraD())
            {
                EstadoActual = 50;
                FormarLexema();
            }
            else
            {
                EstadoActual = 4;
                FormarLexema();
            }

        }
        private void ProcesarEstado50()
        {
            LeerSiguienteCaracter();

            if (EsLetraA())
            {
                EstadoActual = 51;
                FormarLexema();
            }
            else
            {
                EstadoActual = 4;
                FormarLexema();
            }

        }
        private void ProcesarEstado51()
        {
            LeerSiguienteCaracter();

            if (EsLetraD())
            {
                EstadoActual = 52;
                FormarLexema();
            }
            else
            {
                EstadoActual = 4;
                FormarLexema();
            }

        }
        private void ProcesarEstado52()
        {
            LeerSiguienteCaracter();

            if (EsLetraE())
            {
                EstadoActual = 53;
                FormarLexema();
            }
            else
            {
                EstadoActual = 4;
                FormarLexema();
            }

        }
        private void ProcesarEstado53()
        {
            LeerSiguienteCaracter();

            if (EsLetraR())
            {
                EstadoActual = 54;
                FormarLexema();
            }
            else
            {
                EstadoActual = 4;
                FormarLexema();
            }

        }
        private void ProcesarEstado54()
        {
            LeerSiguienteCaracter();

            if (EsLetraO())
            {
                EstadoActual = 55;
                FormarLexema();
            }
            else
            {
                EstadoActual = 4;
                FormarLexema();
            }

        }
        private void ProcesarEstado55()
        {
            //String Categoria = "VERDADERO";
            int NumeroLinea = NumeroLineaActual;
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.LITERAL + "," + Categoria.VERDADERO + "," + Lexema + ")";
            FormarComponente(Lexema, Categoria.VERDADERO, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.LITERAL);

            ContinuarAnalisis = false;
        }
        private void ProcesarEstado56()
        {
            int NumeroLinea = NumeroLineaActual;
            DevolverPuntero();
            //throw new Exception("Asignación diferencia no válida con el caracter:" + CaracterActual + ", No es permitida.");
            MessageBox.Show("Error en linea " + NumeroLinea + ": Se esperaba la letra E");
            ContinuarAnalisis = false;

        }
        private void ProcesarEstado57()
        {
            int NumeroLinea = NumeroLineaActual;
            DevolverPuntero();
            //throw new Exception("Asignación diferencia no válida con el caracter:" + CaracterActual + ", No es permitida.");
            MessageBox.Show("Error en linea " + NumeroLinea + ": Se esperaba la letra R");
            ContinuarAnalisis = false;

        }
        private void ProcesarEstado58()
        {
            int NumeroLinea = NumeroLineaActual;
            DevolverPuntero();
            //throw new Exception("Asignación diferencia no válida con el caracter:" + CaracterActual + ", No es permitida.");
            MessageBox.Show("Error en linea " + NumeroLinea + ": Se esperaba la letra D");
            ContinuarAnalisis = false;

        }
        private void ProcesarEstado59()
        {
            int NumeroLinea = NumeroLineaActual;
            DevolverPuntero();
            //throw new Exception("Asignación diferencia no válida con el caracter:" + CaracterActual + ", No es permitida.");
            MessageBox.Show("Error en linea " + NumeroLinea + ": Se esperaba la letra A");
            ContinuarAnalisis = false;

        }
        private void ProcesarEstado60()
        {
            int NumeroLinea = NumeroLineaActual;
            DevolverPuntero();
            //throw new Exception("Asignación diferencia no válida con el caracter:" + CaracterActual + ", No es permitida.");
            MessageBox.Show("Error en linea " + NumeroLinea + ": Se esperaba la letra O");
            ContinuarAnalisis = false;

        }
        private void ProcesarEstado61()
        {
            LeerSiguienteCaracter();




            if (EsLetraA())
            {
                EstadoActual = 62;
                FormarLexema();
            }
            else
            {
                EstadoActual = 4;
                FormarLexema();
            }
        }



        private void ProcesarEstado62()
        {
            LeerSiguienteCaracter();




            if (EsLetraL())
            {
                EstadoActual = 63;
                FormarLexema();
            }
            else
            {
                EstadoActual = 4;
                FormarLexema();
            }
        }



        private void ProcesarEstado63()
        {
            LeerSiguienteCaracter();




            if (EsLetraS())
            {
                EstadoActual = 64;
                FormarLexema();
            }
            else
            {
                EstadoActual = 4;
                FormarLexema();
            }
        }



        private void ProcesarEstado64()
        {
            LeerSiguienteCaracter();




            if (EsLetraO())
            {
                EstadoActual = 65;
                FormarLexema();
            }
            else
            {
                EstadoActual = 4;
                FormarLexema();
            }
        }
        private void ProcesarEstado65()
        {
            //String Categoria = "FALSO";
            int NumeroLinea = NumeroLineaActual;
            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero - 1;

            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.LITERAL + "," + Categoria.FALSO + "," + Lexema + ")";

            FormarComponente(Lexema, Categoria.FALSO, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.LITERAL);

            ContinuarAnalisis = false;
        }

        private void ProcesarEstado66()
        {
            DevolverPuntero();

            int PosicionInicial = Puntero - Lexema.Length;
            int PosicionFinal = Puntero;


            //MessageBox.Show("Categoria:" + Categoria + ", Lexema:" + Lexema);
            ResultadoAnaLex = ResultadoAnaLex + "(" + Tipo.DUMMY + "," + Categoria.CADENA + "," + Lexema + ")";

            FormarComponente(Lexema + '"', Categoria.CADENA, NumeroLineaActual, PosicionInicial, PosicionFinal, Tipo.DUMMY);

            string Falla = "Cadena no valida: " + Lexema + CaracterActual;
            string Causa = "La cadena no se cerro" + " se esperaba signo "+'"';
            string Solucion = "Asegurese que luego de escribir una cadena, cerrarla con "+ '"';

            Error Error = Error.Crear(NumeroLineaActual, PosicionInicial, PosicionFinal, Falla, Causa, Solucion, TipoError.LEXICO);
            GestorErrores.ObtenerInstancia().Agregar(Error);
            ContinuarAnalisis = false;

        }
        private bool EsFinLinea()
        {
            return "@FL@".Equals(CaracterActual);
        }
        private bool EsFinArchivo()
        {
            return "@EOF@".Equals(CaracterActual);
        }

        private void FormarLexema()
        {
            Lexema = Lexema + CaracterActual;
        }

        private void DevorarEspacioBlanco()
        {
            String Blanco = " ";

            while (Blanco.Equals(CaracterActual))
            {
                LeerSiguienteCaracter();
            }
        }

        private bool EsLetra()
        {
            return Char.IsLetter(CaracterActual.ToCharArray()[0]);

        }

        private bool EsGuionBajo()
        {
            return "_".Equals(CaracterActual);
        }

        private bool EsSimboloPesos()
        {
            return "$".Equals(CaracterActual);
        }

        private bool EsDigito()
        {
            return Char.IsDigit(CaracterActual.ToCharArray()[0]);

        }

        private bool EsSignoSuma()
        {
            return "+".Equals(CaracterActual);
        }

        private bool EsSignoResta()
        {
            return "-".Equals(CaracterActual);
        }

        private bool EsSignoMultiplicacion()
        {
            return "*".Equals(CaracterActual);
        }

        private bool EsSignoDivision()
        {
            return "/".Equals(CaracterActual);
        }

        private bool EsSignoModulo()
        {
            return "%".Equals(CaracterActual);
        }

        private bool EsParentesisAbre()
        {
            return "(".Equals(CaracterActual);
        }

        private bool EsParentesisCierra()
        {
            return ")".Equals(CaracterActual);
        }

        private bool EsSignoMayor()
        {
            return ">".Equals(CaracterActual);
        }

        private bool EsSignoMenor()
        {
            return "<".Equals(CaracterActual);
        }

        private bool EsSignoIgual()
        {
            return "=".Equals(CaracterActual);
        }

        private bool EsDosPuntos()
        {
            return ":".Equals(CaracterActual);
        }

        private bool EsSignoAdmiracion()
        {
            return "!".Equals(CaracterActual);
        }

        private bool EsComa()
        {
            return ",".Equals(CaracterActual);
        }

        private bool EsComamillaSimple()
        {
            return "\u0027".Equals(CaracterActual);
        }

        private bool EsComamillaDoble()
        {
            return "\u0022".Equals(CaracterActual);
        }

     

        private bool EsLetraF()
        {
            return "F".Equals(CaracterActual);
        }

        private bool EsLetraA()
        {
            return "A".Equals(CaracterActual);
        }

        private bool EsLetraL()
        {
            return "L".Equals(CaracterActual);
        }

        private bool EsLetraS()
        {
            return "S".Equals(CaracterActual);
        }
        private bool EsLetraO()
        {
            return "O".Equals(CaracterActual);
        }
        private bool EsLetraV()
        {
            return "V".Equals(CaracterActual);
        }
        private bool EsLetraE()
        {
            return "E".Equals(CaracterActual);
        }
        private bool EsLetraR()
        {
            return "R".Equals(CaracterActual);
        }
        private bool EsLetraD()
        {
            return "D".Equals(CaracterActual);
        }
      
    }
}
