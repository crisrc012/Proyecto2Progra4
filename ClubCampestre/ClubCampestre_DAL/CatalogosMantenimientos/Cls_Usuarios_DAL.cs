namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Usuarios_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private string _sIdUsuario; private string _sIdPersona; private string _sContrasena;

        public string SIdUsuario
        {
            get
            {
                return _sIdUsuario;
            }

            set
            {
                _sIdUsuario = value;
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

        public string SContrasena
        {
            get
            {
                return _sContrasena;
            }

            set
            {
                _sContrasena = value;
            }
        }
        #endregion
    }
}
