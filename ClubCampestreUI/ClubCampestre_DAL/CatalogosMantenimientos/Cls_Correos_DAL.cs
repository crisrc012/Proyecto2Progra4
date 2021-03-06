namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Correos_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sIdCorreo; private string _sIdPersona; private string _sCorreo, _sMsjError;
        public Cls_Correos_DAL()
        {
            this.sCorreo = string.Empty;
            this.sIdCorreo = short.MinValue;
            this.sIdPersona = string.Empty;
            this.sMsjError = string.Empty;
        }
        public short sIdCorreo
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

        public string sCorreo
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
