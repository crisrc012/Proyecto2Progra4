using System;

namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Ingresos_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sPKIdCliente; private DateTime _DFKFecha;

        public short SPKIdCliente
        {
            get
            {
                return _sPKIdCliente;
            }

            set
            {
                _sPKIdCliente = value;
            }
        }

        public DateTime DFKFecha
        {
            get
            {
                return _DFKFecha;
            }

            set
            {
                _DFKFecha = value;
            }
        }
        #endregion
    }
}
