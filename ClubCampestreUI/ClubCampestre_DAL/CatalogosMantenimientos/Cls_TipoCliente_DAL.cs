using System.Data;

namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_TipoCliente_DAL
    {
        #region Variables
        public DataSet DS = new DataSet();
        private byte _bIdTipoCliente ; private string _sDescripcion, _sMsjError;

       

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

        #endregion
    }
}
