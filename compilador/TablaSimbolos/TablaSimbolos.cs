using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using compilador.Transversal;

namespace compilador.TablaSimbolos
{
    public class TablaSimbolos
    {
        private Dictionary<string, List<ComponenteLexico>> Tabla = new Dictionary<string, List<ComponenteLexico>>();
        private static TablaSimbolos INSTANCIA = new TablaSimbolos();

        private TablaSimbolos()
        {

        }

        public static TablaSimbolos ObtenerInstancia()
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
            if(Componente != null && Tipo.SIMBOLO.Equals(Componente.ObtenerTipo()))
            {
                ObtenerSimbolo(Componente.ObtenerLexema()).Add(Componente);
            }
        }

        public List<ComponenteLexico> ObtenerComponentes()
        {
            List<ComponenteLexico> Componentes = new List<ComponenteLexico>();

            foreach(List<ComponenteLexico> Lista in Tabla.Values)
            {
                Componentes.AddRange(Lista);
            }
            return Componentes;
        }
    }
}
