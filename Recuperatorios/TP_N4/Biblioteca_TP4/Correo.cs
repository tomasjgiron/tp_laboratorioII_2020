using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca_TP4
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        public Correo()
        {
            this.paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }

        public void FinEntregas()
        {
            foreach (Thread hilo in this.mockPaquetes)
            {
                hilo.Abort();
            }
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            StringBuilder cadenaCorreo = new StringBuilder();
            foreach (Paquete pack in this.Paquetes)
            {
                cadenaCorreo.AppendLine(string.Format($"{pack.ToString()} ({pack.Estado.ToString()})"));
            }
            return cadenaCorreo.ToString();
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            if (!(c is null) && !(p is null))
            {
                foreach (Paquete pack in c.Paquetes)
                {
                    if (pack == p)
                    {
                        throw new TrackingIdRepetidoException($"El tracking ID {p.TrackingID} ya figura en la lista");
                    }
                }
                c.Paquetes.Add(p);
                Thread tPaquete = new Thread(p.MockCicloDeVida);
                c.mockPaquetes.Add(tPaquete);
                tPaquete.Start();
            }
            return c;
        }
    }
}
