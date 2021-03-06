namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_TipoMembresia_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bIdTipoMembresia; private string _sDescripcion, _sMsjError; private float _fcosto; 
        public Cls_TipoMembresia_DAL()
        {
            this.bIdTipoMembresia = byte.MinValue;
            this.fCosto = 0;
            this.sDescripcion = string.Empty;
            this.sMsjError = string.Empty;
        }
        public byte bIdTipoMembresia
        {
            get
            {
                return _bIdTipoMembresia;
            }

            set
            {
                _bIdTipoMembresia = value;
            }
        }

        public string sDescripcion
        {
            get
            {
                return _sDescripcion;
            }

            set
            {
                _sDescripcion = value;
            }
        }

        public float fCosto
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

        public string sMsjError
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
