namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_TipoCliente_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bIdTipoCliente; private string _sPKDescripcion; private string _sMsjError;

        public byte BIdTipoCliente
        {
            get
            {
                return _bIdTipoCliente;
            }

            set
            {
                _bIdTipoCliente = value;
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
