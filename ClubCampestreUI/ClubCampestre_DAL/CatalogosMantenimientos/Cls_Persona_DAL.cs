namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Persona_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sIdPersona; private string _sNombre; private string _sDireccion; private byte _bIdRol; private string _sMsjError;

        public short SIdPersona
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

        public string SNombre
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

        public string SDireccion
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

        public byte BIdRol
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
