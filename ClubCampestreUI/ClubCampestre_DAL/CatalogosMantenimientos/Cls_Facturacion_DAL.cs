using System;

namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Facturacion_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private short _sIdCliente; private string _sDescripcion; private DateTime _DFecha; private float _fMontototal; private string _sMsjError; private int _iIdFactura;

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

        public int IIdFactura
        {
            get
            {
                return _iIdFactura;
            }

            set
            {
                _iIdFactura = value;
            }
        }
        #endregion
    }
}
