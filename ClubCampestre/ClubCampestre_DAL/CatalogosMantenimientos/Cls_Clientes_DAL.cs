namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Clientes_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sIdCliente; private byte _bIdTipoCliente; private string _sIdPersona, _sMsjError;

        public short SIdCliente
        {
            get
            {
                return _sIdCliente;
            }

            set
            {
                _sIdCliente = value;
            }
        }

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

        public string SIdPersona
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
