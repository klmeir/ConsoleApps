using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    public class LibroValoraciones
    {

        public List<float> valoraciones;

        public LibroValoraciones()
        {
            valoraciones = new List<float>();
        }

        public CalcularValoraciones PublicarValoraciones()
        {
            CalcularValoraciones calculo = new CalcularValoraciones();
            float sumaValoraciones = 0;
            foreach(float valoracion in valoraciones)
            {
                calculo.ValoracionMin = Math.Min(valoracion, calculo.ValoracionMin);
                calculo.ValoracionMax = Math.Max(valoracion, calculo.ValoracionMax);
                sumaValoraciones += valoracion;
            }
            calculo.PromedioValoraciones = sumaValoraciones / valoraciones.Count;
            return calculo;
        }

        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion);
        }

    }
}
