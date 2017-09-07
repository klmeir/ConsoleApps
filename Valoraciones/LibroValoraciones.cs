using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    public enum IdiomaLibro
    {
        none, EN, ES, GE, IT
    }

    public class LibroValoraciones
    {
        private string _valoracionesLetras;
        public string ValoracionesLetras
        {
            get
            {
                return _valoracionesLetras;
            }
        }
        private string _nombre;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    _nombre = value;
                }                
            }
        }
        public IdiomaLibro Idioma;
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
            AsignarLetraValoracion(calculo.PromedioValoraciones);
            return calculo;
        }

        private void AsignarLetraValoracion(float pV)
        {
            if (pV <= 5 && pV > 4)
            {
                _valoracionesLetras = "A";
            } else if (pV <= 4 && pV > 3)
            {
                _valoracionesLetras = "B";
            } else if (pV <= 3 && pV > 2)
            {
                _valoracionesLetras = "C";
            } else if (pV <= 2 && pV > 1)
            {
                _valoracionesLetras = "D";
            } else
            {
                _valoracionesLetras = "E";
            }
        }

        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion);
        }

    }
}
