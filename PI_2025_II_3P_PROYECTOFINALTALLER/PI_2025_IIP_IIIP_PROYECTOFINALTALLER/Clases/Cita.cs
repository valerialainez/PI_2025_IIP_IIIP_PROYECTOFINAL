using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_IIP_IIIP_PROYECTOFINALTALLER.clases
{
    internal class Cita
    {
        private string idCliente;
        private string telefono;
        private string placaVehiculo;
        private DateTime fechaHora;
        private string idCita;
        private string motivoVisita;
        private string estadoCita;
        private string empleadoAsignado;
        private string observaciones;

        public Cita(string pIdCliente, string pTelefono, string pPlacaVehiculo, DateTime pFechaHora, string pIdCita, string pMotivoVisita, string pEstadoCita, string pEmpleadoAsignado, string pObservaciones)
        {
            idCliente = pIdCliente;
            telefono = pTelefono;
            placaVehiculo = pPlacaVehiculo;
            fechaHora = pFechaHora;
            idCita = pIdCita;
            motivoVisita = pMotivoVisita;
            estadoCita = pEstadoCita;
            empleadoAsignado = pEmpleadoAsignado;
            observaciones = pObservaciones;
        }

        public string IdCliente
        {
            get { return idCliente; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    idCliente = value;
                }
                else
                {
                    throw new ArgumentException("El ID del cliente no puede estar vacío.");
                }
            }
        }

        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    telefono = value;
                }
                else
                {
                    throw new ArgumentException("El teléfono no puede estar vacío.");
                }
            }
        }

        public string PlacaVehiculo
        {
            get { return placaVehiculo; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    placaVehiculo = value;
                }
                else
                {
                    throw new ArgumentException("La placa del vehículo no puede estar vacía.");
                }
            }
        }

        public DateTime FechaHora
        {
            get { return fechaHora; }
            set
            {
                if (value > DateTime.Now)
                {
                    fechaHora = value;
                }
                else
                {
                    throw new ArgumentException("La fecha y hora de la cita debe ser futura.");
                }
            }
        }

        public string IdCita
        {
            get { return idCita; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    idCita = value;
                }
                else
                {
                    throw new ArgumentException("El ID de la cita no puede estar vacío.");
                }
            }
        }

        public string MotivoVisita
        {
            get { return motivoVisita; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    motivoVisita = value;
                }
                else
                {
                    throw new ArgumentException("El motivo de la visita no puede estar vacío.");
                }
            }
        }

        public string EstadoCita
        {
            get { return estadoCita; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    estadoCita = value;
                }
                else
                {
                    throw new ArgumentException("El estado de la cita no puede estar vacío.");
                }
            }
        }

        public string EmpleadoAsignado
        {
            get { return empleadoAsignado; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    empleadoAsignado = value;
                }
                else
                {
                    throw new ArgumentException("El empleado asignado no puede estar vacío.");
                }
            }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    observaciones = value;
                }
                else
                {
                    throw new ArgumentException("Las observaciones no pueden estar vacías.");
                }
            }

        }

        public string MostrarResumen()
        {
            return $"Cita ID: {IdCita}\n" +
                   $"Cliente ID: {IdCliente}\n" +
                   $"Teléfono: {Telefono}\n" +
                   $"Placa Vehículo: {PlacaVehiculo}\n" +
                   $"Fecha y Hora: {FechaHora}\n" +
                   $"Motivo de Visita: {MotivoVisita}\n" +
                   $"Estado de Cita: {EstadoCita}\n" +
                   $"Empleado Asignado: {EmpleadoAsignado}\n" +
                   $"Observaciones: {Observaciones}";
        }
    }
}
        