namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Persona_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private string _sIdPersona; private string _sNombre; private string _sDireccion; private byte _bIdRol; private string _sRol; private string _sMsjError;
        public Cls_Persona_DAL()
        {
            sIdPersona = string.Empty;
            sNombre = string.Empty;
            sDireccion = string.Empty;
            bIdRol = byte.MinValue;
            sRol = string.Empty;
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

        public string sNombre
        {
            get
            {
                return _sNombre;
            }

            set
            {
                _sNombre = value;
            }
        }

        public string sDireccion
        {
            get
            {
                return _sDireccion;
            }

            set
            {
                _sDireccion = value;
            }
        }

        public byte bIdRol
        {
            get
            {
                return _bIdRol;
            }

            set
            {
                _bIdRol = value;
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

        public string sRol
        {
            get
            {
                return _sRol;
            }

            set
            {
                _sRol = value;
            }
        }
        #endregion
    }
}
