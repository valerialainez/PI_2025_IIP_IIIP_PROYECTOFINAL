using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_IIP_IIIP_PROYECTOFINALTALLER.clases
{
    internal class Proveedor
    {
		private int idProveedor;
		private string empresa;
		private string direccionEmpresa;
		private string tipoMaterial;
		private DateTime fechaRegistroo;

		public int IdProveedor
		{
			get { return idProveedor; }
			set 
			{ 
				if (value > 0)
				{
					idProveedor = value;
				}
				else
				{
					throw new ArgumentException("El ID del proveedor debe ser un número positivo.");
                }
            }
        }


		public string Empresa
		{
			get { return empresa; }
			set
			{ 
				if (!string.IsNullOrWhiteSpace(value))
				{
					empresa = value;
				}
				else
				{
					throw new ArgumentException("El nombre de la empresa no puede estar vacío.");
                }
            }
        }


		public string DireccionEmpresa
		{
			get { return direccionEmpresa; }
			set 
			{ 
				if (!string.IsNullOrWhiteSpace(value))
				{
					direccionEmpresa = value;
				}
				else
				{
					throw new ArgumentException("La dirección de la empresa no puede estar vacía.");
                }
            }
			
        }

		public string TipoMaterial
		{
			get { return tipoMaterial; }
			set 
			{
				if (!string.IsNullOrWhiteSpace(value))
				{
					tipoMaterial = value;
				}
				else
				{
					throw new ArgumentException("El tipo de material no puede estar vacío.");
                }
            }
        }


		public DateTime FechaRegistroo
		{
			get { return fechaRegistroo; }
			set
			{
				if (value <= DateTime.Now)
				{
					fechaRegistroo = value;
				}
				else
				{
					throw new ArgumentException("La fecha de registro no puede ser futura.");
                }
            }
        }
		

    }
}
