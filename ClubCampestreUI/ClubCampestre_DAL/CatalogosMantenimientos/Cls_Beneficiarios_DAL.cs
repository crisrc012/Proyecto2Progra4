namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Beneficiarios_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sIdBeneficiario; private short _sIdCliente; private string _sIdPersona; private char _cIdEstado; private string _sMsjError;

        public short sIdBeneficiario
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

        public char cIdEstado
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
