using compilador.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilador.TablaSimbolos
{
    public class TablaLiterales
    {
        private Dictionary<string, List<ComponenteLexico>> Tabla = new Dictionary<string, List<ComponenteLexico>>();
        private static TablaLiterales INSTANCIA = new TablaLiterales();

        private TablaLiterales()
        {

        }

        public static TablaLiterales ObtenerInstancia()
        {
            return INSTANCIA;
        }

        public void Limpiar()
        {
            Tabla.Clear();
        }

        private List<ComponenteLexico> ObtenerSimbolo(string Simbolo)
        {
            if (!Tabla.ContainsKey(Simbolo))
            {
                Tabla.Add(Simbolo, new List<ComponenteLexico>());
            }
            return Tabla[Simbolo];
        }

        public void Agregar(ComponenteLexico Componente)
        {
            if (Componente != null && Tipo.LITERAL.Equals(Componente.ObtenerTipo()))
            {
                ObtenerSimbolo(Componente.ObtenerLexema()).Add(Componente);

            }
        }

        public List<ComponenteLexico> ObtenerComponentes()
        {
            List<ComponenteLexico> Componentes = new List<ComponenteLexico>();

            foreach (List<ComponenteLexico> Lista in Tabla.Values)
            {
                Componentes.AddRange(Lista);
            }
            return Tabla.Values.SelectMany(componente => componente).ToList();
        }
    }
}
