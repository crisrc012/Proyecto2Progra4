namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Beneficiarios_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sIdBeneficiario; private short _sPKIdCliente; private string _sFKIdPersona; private char _cFKIdEstado;

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

        public short SPKIdCliente
        {
            get
            {
                return _sPKIdCliente;
            }

            set
            {
                _sPKIdCliente = value;
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

        public char CFKIdEstado
        {
            get
            {
                return _cFKIdEstado;
            }

            set
            {
                _cFKIdEstado = value;
            }
        }
        #endregion
    }
}
