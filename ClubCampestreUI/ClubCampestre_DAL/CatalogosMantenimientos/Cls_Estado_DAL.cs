namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Estado_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private char _cIdEstado;
        private string _sPKEstado, _sMsjError;

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

        public string sPKEstado
        {
            get
            {
                return _sPKEstado;
            }

            set
            {
                _sPKEstado = value;
            }
        }
        #endregion
    }
}
