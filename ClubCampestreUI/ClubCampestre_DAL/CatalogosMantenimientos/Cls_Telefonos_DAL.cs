namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Telefonos_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private string _sTelefono; private string _sIdPersona; private string _sMsjError;
        public Cls_Telefonos_DAL()
        {
            this.sIdPersona = string.Empty;
            this.sMsjError = string.Empty;
            this.sTelefono = string.Empty;
        }
        public string sTelefono
        {
            get
            {
                return _sTelefono;
            }

            set
            {
                _sTelefono = value;
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
