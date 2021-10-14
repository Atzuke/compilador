using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using compilador.TablaSimbolos;
using compilador.Transversal;



namespace compilador.TablaSimbolos
{
    public class Tabla
    {
        private static Tabla INSTANCIA = new Tabla();

        private Tabla()
        {
        }

        public static Tabla ObtenerInstancia()
        {
            return INSTANCIA;
        }

        public void Agregar(ComponenteLexico Componente)
        {
            TablaPalabrasReservadas.ObtenerInstancia().Agregar(Componente);
            TablaSimbolos.ObtenerInstancia().Agregar(Componente);
            TablaLiterales.ObtenerInstancia().Agregar(Componente);
            TablaDummy.ObtenerInstancia().Agregar(Componente);
        }

        public void Limpiar(Tipo Tipo)
        {
            if (Tipo.SIMBOLO.Equals(Tipo))
            {
                TablaSimbolos.ObtenerInstancia().Limpiar();
            }
            else if (Tipo.LITERAL.Equals(Tipo)){
                TablaLiterales.ObtenerInstancia().Limpiar();
            }
            else if (Tipo.PALABRA_RESERVADA.Equals(Tipo))
            {
                TablaPalabrasReservadas.ObtenerInstancia().Limpiar();
            }
            else if (Tipo.DUMMY.Equals(Tipo))
            {
                TablaDummy.ObtenerInstancia().Limpiar();
            }
        }

        public List<ComponenteLexico> ObtenerComponentes(Tipo Tipo)
        {
            List<ComponenteLexico> Componentes = new List<ComponenteLexico>();

            if (Tipo.SIMBOLO.Equals(Tipo))
            {
                Componentes = TablaSimbolos.ObtenerInstancia().ObtenerComponentes();
            }
            else if (Tipo.LITERAL.Equals(Tipo))
            {
                Componentes = TablaLiterales.ObtenerInstancia().ObtenerComponentes();
            }
            else if (Tipo.PALABRA_RESERVADA.Equals(Tipo))
            {
                Componentes = TablaPalabrasReservadas.ObtenerInstancia().ObtenerComponentes();
            }
            else if (Tipo.DUMMY.Equals(Tipo))
            {
                Componentes = TablaDummy.ObtenerInstancia().ObtenerComponentes();
            }
            return Componentes;
        }
    }
}
