using System;

namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Membresias_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private int  _iIdMembresia;
        private DateTime _dFechaInicio, _dFechaVence;
        private short _sPKIdCliente; private byte _bFKIdTipoMembresia; private char _cFKIdEstado; 
        private string  _sMsjError;
        
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

        public byte BFKIdTipoMembresia
        {
            get
            {
                return _bFKIdTipoMembresia;
            }

            set
            {
                _bFKIdTipoMembresia = value;
            }
        }

        public char CFKIdEstado
        {
            get
            {
                return _cFKIdEstado;
            }

            set
            {
                _cFKIdEstado = value;
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

        public int iIdMembresia
        {
            get
            {
                return _iIdMembresia;
            }

            set
            {
                _iIdMembresia = value;
            }
        }

        public DateTime dFechaInicio
        {
            get
            {
                return _dFechaInicio;
            }

            set
            {
                _dFechaInicio = value;
            }
        }

        public DateTime dFechaVence
        {
            get
            {
                return _dFechaVence;
            }

            set
            {
                _dFechaVence = value;
            }
        }
        #endregion
    }
}
