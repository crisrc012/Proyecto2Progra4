namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Clientes_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sIdCliente; private byte _bIdTipoCliente; private string _sIdPersona, _sMsjError;

        public short sIdCliente
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

        public byte bIdTipoCliente
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
