namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Ingreso_DAL
    {
        public System.Data.DataSet DS = new System.Data.DataSet();
        public System.Data.DataSet DI = new System.Data.DataSet();
        private string _sIdPersona,  _sNombre, _sTipoCliente, _sMembresia, _sMsj_error;
        private float _fTotal, _fCosto;
        byte _bIdTipoServicio;

        public string sIdPersona
        {
            get
            {
                return _sIdPersona;
            }

            set
            {
                _sIdPersona = value;
            }
        }

        public string sNombre
        {
            get
            {
                return _sNombre;
            }

            set
            {
                _sNombre = value;
            }
        }

        public string sTipoCliente
        {
            get
            {
                return _sTipoCliente;
            }

            set
            {
                _sTipoCliente = value;
            }
        }

        public string sMembresia
        {
            get
            {
                return _sMembresia;
            }

            set
            {
                _sMembresia = value;
            }
        }

        public string sMsj_error
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

        public float fCosto
        {
            get
            {
                return _fCosto;
            }

            set
            {
                _fCosto = value;
            }
        }

      

        public byte bIdTipoServicio
        {
            get
            {
                return _bIdTipoServicio;
            }

            set
            {
                _bIdTipoServicio = value;
            }
        }

        public float fTotal
        {
            get
            {
                return _fTotal;
            }

            set
            {
                _fTotal = value;
            }
        }
    }
}
