namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Estado_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private char _cIdEstado; private string _sEstado, _sMsjError;

        public char CIdEstado
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

        public string SEstado
        {
            get
            {
                return _sEstado;
            }

            set
            {
                _sEstado = value;
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
