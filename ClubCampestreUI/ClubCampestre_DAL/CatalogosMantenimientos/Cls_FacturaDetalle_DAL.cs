namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_FacturaDetalle_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private int _iIdFacturaDetalle; private int _iIdFactura; private string _sDetalle; private float _fcosto; private byte _bIdTipoServicio; private int _iIdMembresia; private int _icantidad; private float _ftotal; private string _sMsjError;

        public int IIdFacturaDetalle
        {
            get
            {
                return _iIdFacturaDetalle;
            }

            set
            {
                _iIdFacturaDetalle = value;
            }
        }

        public int IIdFactura
        {
            get
            {
                return _iIdFactura;
            }

            set
            {
                _iIdFactura = value;
            }
        }

        public string SDetalle
        {
            get
            {
                return _sDetalle;
            }

            set
            {
                _sDetalle = value;
            }
        }

        public float Fcosto
        {
            get
            {
                return _fcosto;
            }

            set
            {
                _fcosto = value;
            }
        }

        public byte BIdTipoServicio
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

        public int IIdMembresia
        {
            get
            {
                return _iIdMembresia;
            }

            set
            {
                _iIdMembresia = value;
            }
        }

        public int Icantidad
        {
            get
            {
                return _icantidad;
            }

            set
            {
                _icantidad = value;
            }
        }

        public float Ftotal
        {
            get
            {
                return _ftotal;
            }

            set
            {
                _ftotal = value;
            }
        }

        public string SMsjError
        {
            get
            {
                return _sMsjError;
            }

            set
            {
                _sMsjError = value;
            }
        }
        #endregion
    }
}
