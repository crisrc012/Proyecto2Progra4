namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Servicio_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sIdServicio; private short _sIdCliente; private char _cIdEstado; private byte _bIdTipoServicio;

        public short SIdServicio
        {
            get
            {
                return _sIdServicio;
            }

            set
            {
                _sIdServicio = value;
            }
        }

        public short SIdCliente
        {
            get
            {
                return _sIdCliente;
            }

            set
            {
                _sIdCliente = value;
            }
        }

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

        public byte BIdTipoServicio
        {
            get
            {
                return _bIdTipoServicio;
            }

            set
            {
                _bIdTipoServicio = value;
            }
        }
        #endregion
    }
}
