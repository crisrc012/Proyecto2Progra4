namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_TipoCliente_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bIdTipoCliente; private string _sPKDescripcion;

        public byte BIdTipoCliente
        {
            get
            {
                return _bIdTipoCliente;
            }

            set
            {
                _bIdTipoCliente = value;
            }
        }

        public string SPKDescripcion
        {
            get
            {
                return _sPKDescripcion;
            }

            set
            {
                _sPKDescripcion = value;
            }
        }
        #endregion
    }
}
