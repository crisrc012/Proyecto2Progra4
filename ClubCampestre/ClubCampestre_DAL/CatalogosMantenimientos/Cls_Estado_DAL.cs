namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Estado_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private char _cIdEstado; private string _sPKEstado;

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

        public string SPKEstado
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
