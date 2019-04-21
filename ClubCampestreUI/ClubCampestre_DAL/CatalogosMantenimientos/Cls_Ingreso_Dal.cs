using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCampestre_DAL.CatalogosMantenimientos
{
   public class Cls_Ingreso_Dal
    {
        public System.Data.DataSet DS = new System.Data.DataSet();
        public System.Data.DataSet DI = new System.Data.DataSet();
        private string _IdPersona,  _Nombre, _TipoCliente, _Membresia, _sMsj_error; private float _Costo;
        private double _Total;

        public string IdPersona
        {
            get
            {
                return _IdPersona;
            }

            set
            {
                _IdPersona = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string TipoCliente
        {
            get
            {
                return _TipoCliente;
            }

            set
            {
                _TipoCliente = value;
            }
        }

        public string Membresia
        {
            get
            {
                return _Membresia;
            }

            set
            {
                _Membresia = value;
            }
        }

        public string SMsj_error
        {
            get
            {
                return _sMsj_error;
            }

            set
            {
                _sMsj_error = value;
            }
        }

        public float Costo
        {
            get
            {
                return _Costo;
            }

            set
            {
                _Costo = value;
            }
        }

        public double Total
        {
            get
            {
                return _Total;
            }

            set
            {
                _Total = value;
            }
        }
    }
}
