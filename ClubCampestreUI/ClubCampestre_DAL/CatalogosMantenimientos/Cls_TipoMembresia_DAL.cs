namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_TipoMembresia_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bIdTipoMembresia; private string _sPKDescripcion, _sMsjError; private float _fcosto; 

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
                return _sPKDescripcion;
            }

            set
            {
                _sPKDescripcion = value;
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
