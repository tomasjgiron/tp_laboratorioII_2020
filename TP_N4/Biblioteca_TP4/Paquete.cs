using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca_TP4
{
#pragma warning disable CS0660,CS0661 
    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public enum EEstado
        {
            Ingresado, EnViaje, Entregado
        }

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        public void MockCicloDeVida()
        {
            while (this.Estado != EEstado.Entregado)
            {
                Thread.Sleep(4000);
                switch (this.Estado)
                {
                    case EEstado.Ingresado:
                        {
                            this.Estado = EEstado.EnViaje;
                            break;
                        }
                    case EEstado.EnViaje:
                        {
                            this.Estado = EEstado.Entregado;
                            break;
                        }
                }
                InformarEstado(this.estado, new EventArgs());
            }
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format($"{this.TrackingID} para {this.DireccionEntrega}");
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool retorno = false;
            if (!(p1 is null) && !(p2 is null))
            {
                retorno = p1.TrackingID == p2.TrackingID;
            }
            return retorno;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public delegate void DelegadoEstado(object sender, EventArgs e);

        public event DelegadoEstado InformarEstado;
    }
}
