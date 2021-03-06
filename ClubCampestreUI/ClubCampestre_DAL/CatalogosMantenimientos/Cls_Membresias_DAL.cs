using System;

namespace ClubCampestre_DAL.CatalogosMantenimientos
{
    public class Cls_Membresias_DAL
    {
        #region Variables
        public System.Data.DataSet DS = new System.Data.DataSet();
        private int  _iIdMembresia;
        private DateTime _dFechaInicio, _dFechaVence;
        private short _sIdCliente; private byte _bIdTipoMembresia; private char _cIdEstado; 
        private string  _sMsjError;
        
        public short sIdCliente
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

        public byte bIdTipoMembresia
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

        public char cIdEstado
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

        public string sMsjError
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
