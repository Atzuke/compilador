using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilador.Transversal
{
    public class ComponenteLexico
    {
        private string Lexema;
        private Categoria Categoria;
        private int NumeroLinea;
        private int PosicionInicial;
        private int PosicionFinal;
        private Tipo Tipo;

        private ComponenteLexico(string Lexema, Categoria Categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal, Tipo Tipo){
            this.Lexema = Lexema;
            this.Categoria = Categoria;
            this.NumeroLinea = NumeroLinea;
            this.PosicionInicial = PosicionInicial;
            this.PosicionFinal = PosicionFinal;
            this.Tipo = Tipo;
        }
        public static ComponenteLexico Crear(string Lexema, Categoria Categoria,Tipo Tipo)
        {
            return new ComponenteLexico(Lexema, Categoria, 0, 0, 0, Tipo);
        }
        public static ComponenteLexico Crear(string Lexema, Categoria Categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal, Tipo Tipo)
        {
            return new ComponenteLexico(Lexema, Categoria, NumeroLinea, PosicionInicial, PosicionFinal, Tipo);
        }
        public static ComponenteLexico CrearSimbolo(string Lexema, Categoria Categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            return new ComponenteLexico(Lexema, Categoria, NumeroLinea, PosicionInicial, PosicionFinal, Tipo.SIMBOLO);
        }

        public static ComponenteLexico CrearLiteral(string Lexema, Categoria Categoria, int NumeroLinea, int PosicionInicial, int PosicionFinal)
        {
            return new ComponenteLexico(Lexema, Categoria, NumeroLinea, PosicionInicial, PosicionFinal, Tipo.LITERAL);
        }

        public string ObtenerLexema()
        {
            return Lexema;
        }

        public Categoria ObtenerCategoria()
        {
            return Categoria;
        }

        public int ObtenerNumeroLinea()
        {
            return NumeroLinea;
        }

        public int ObtenerPosicionInicial()
        {
            return PosicionInicial;
        }

        public int ObtenerPosicionFinal()
        {
            return PosicionFinal;
        }

        public Tipo ObtenerTipo()
        {
            return Tipo;
        }

        public string Mostrar()
        {
            StringBuilder Retorno = new StringBuilder();
            string SaltoLinea = "\n";

            Retorno.Append("Tipo componente: ").Append(ObtenerTipo()).Append(SaltoLinea);
            Retorno.Append(" Categoría: ").Append(ObtenerCategoria()).Append(SaltoLinea);
            Retorno.Append(" Lexema: ").Append(ObtenerLexema()).Append(SaltoLinea);
            Retorno.Append(" Número línea: ").Append(ObtenerNumeroLinea()).Append(SaltoLinea);
            Retorno.Append(" Posición inicial línea: ").Append(ObtenerPosicionInicial()).Append(SaltoLinea);
            Retorno.Append(" Posición final línea: ").Append(ObtenerPosicionFinal()).AppendLine().AppendLine();

            return Retorno.ToString();
        }
    }

   
}
