namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Rol_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bIdRol; private string _sDescripcion, _sMsjError;

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

        public string sDescripcion
        {
            get
            {
                return _sDescripcion;
            }

            set
            {
                _sDescripcion = value;
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
