namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Correos_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sIdCorreo; private string _sIdPersona; private string _sCorreo;

        public short SIdCorreo
        {
            get
            {
                return _sIdCorreo;
            }

            set
            {
                _sIdCorreo = value;
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

        public string SCorreo
        {
            get
            {
                return _sCorreo;
            }

            set
            {
                _sCorreo = value;
            }
        }
        #endregion
    }
}
