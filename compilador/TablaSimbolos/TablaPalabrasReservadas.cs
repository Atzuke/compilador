using compilador.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilador.TablaSimbolos
{
    public class TablaPalabrasReservadas
    {
        private Dictionary<string, ComponenteLexico> TablaReservadas = new Dictionary<string, ComponenteLexico>();
        private Dictionary<string, List<ComponenteLexico>> Tabla = new Dictionary<string, List<ComponenteLexico>>();
        private static TablaPalabrasReservadas INSTANCIA = new TablaPalabrasReservadas();

        private TablaPalabrasReservadas()
        {
           
        }

        public static TablaPalabrasReservadas ObtenerInstancia()
        {
            return INSTANCIA;
        }
        private void Inicializar()
        {
            TablaReservadas.Add("Palabra", ComponenteLexico.Crear("Palabra", Categoria.PALABRA,Tipo.PALABRA_RESERVADA));
            TablaReservadas.Add("OtraPalabra", ComponenteLexico.Crear("OtraPalabra", Categoria.PALABRA, Tipo.PALABRA_RESERVADA));
        }
        private void ValidarSiComponenteEsPalabraReservada(ComponenteLexico Componente)
        {
            if(Componente != null && TablaReservadas.ContainsKey(Componente.ObtenerLexema())){
                ComponenteLexico PalabraReservada = TablaReservadas[Componente.ObtenerLexema()];
                Componente = ComponenteLexico.Crear(PalabraReservada.ObtenerLexema(), PalabraReservada.ObtenerCategoria(), Componente.ObtenerNumeroLinea(), Componente.ObtenerPosicionInicial(), Componente.ObtenerPosicionFinal(), Tipo.PALABRA_RESERVADA);
            }
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
            ValidarSiComponenteEsPalabraReservada(Componente);

            if (Componente != null && Tipo.PALABRA_RESERVADA.Equals(Componente.ObtenerTipo()))
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
            return Componentes;
        }
    }
}
