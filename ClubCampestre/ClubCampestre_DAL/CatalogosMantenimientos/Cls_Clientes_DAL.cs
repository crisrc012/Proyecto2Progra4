namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Clientes_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sIdCliente; private byte _bPKIdTipoCliente; private string _sFKIdPersona; private string _sMsjError;

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

        public byte BPKIdTipoCliente
        {
            get
            {
                return _bPKIdTipoCliente;
            }

            set
            {
                _bPKIdTipoCliente = value;
            }
        }

        public string SFKIdPersona
        {
            get
            {
                return _sFKIdPersona;
            }

            set
            {
                _sFKIdPersona = value;
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
