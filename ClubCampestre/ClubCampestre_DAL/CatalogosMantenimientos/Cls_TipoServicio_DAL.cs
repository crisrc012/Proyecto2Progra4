namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_TipoServicio_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bIdTipoServicio; private string _sPKDescripcion; private float _fcosto; private string _sMsjError;

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

        public string SPKDescripcion
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
