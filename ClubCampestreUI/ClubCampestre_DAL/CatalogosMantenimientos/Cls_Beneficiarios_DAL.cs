namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Beneficiarios_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sIdBeneficiario; private short _sIdCliente; private string _sIdPersona; private char _cIdEstado; private string _sMsjError;

        public short SIdBeneficiario
        {
            get
            {
                return _sIdBeneficiario;
            }

            set
            {
                _sIdBeneficiario = value;
            }
        }

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

        public char CIdEstado
        {
            get
            {
                return _cIdEstado;
            }

            set
            {
                _cIdEstado = value;
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
