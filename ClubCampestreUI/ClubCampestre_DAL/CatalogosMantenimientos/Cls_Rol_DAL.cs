namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Rol_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bIdRol; private string _sDescripcion;

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

        public string SDescripcion
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
        #endregion
    }
}
