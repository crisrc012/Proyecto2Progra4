using System;

namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Facturacion_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sPKIdCliente; private string _sFKDescripcion; private DateTime _DFecha; private float _fMontototal;

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

        public string SFKDescripcion
        {
            get
            {
                return _sFKDescripcion;
            }

            set
            {
                _sFKDescripcion = value;
            }
        }

        public DateTime DFecha
        {
            get
            {
                return _DFecha;
            }

            set
            {
                _DFecha = value;
            }
        }

        public float FMontototal
        {
            get
            {
                return _fMontototal;
            }

            set
            {
                _fMontototal = value;
            }
        }
        #endregion
    }
}
