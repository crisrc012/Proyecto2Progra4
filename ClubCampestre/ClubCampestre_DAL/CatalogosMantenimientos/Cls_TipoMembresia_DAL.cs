namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_TipoMembresia_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private byte _bIdTipoMembresia; private string _sPKDescripcion; private float _fcosto;

        public byte BIdTipoMembresia
        {
            get
            {
                return _bIdTipoMembresia;
            }

            set
            {
                _bIdTipoMembresia = value;
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

        public float Fcosto
        {
            get
            {
                return _fcosto;
            }

            set
            {
                _fcosto = value;
            }
        }
        #endregion
    }
}
