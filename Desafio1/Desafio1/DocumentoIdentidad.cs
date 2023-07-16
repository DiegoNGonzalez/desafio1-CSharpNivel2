using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class DocumentoIdentidad
    {
        private string nombre;
        private string apellido;
        private int nroDocumento;
        private string genero;
        private string nacionalidad;
        public DocumentoIdentidad(int nroDocumento)
        {
            this.nroDocumento = nroDocumento;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Genero 
        {
            get { return genero; }
            set { genero = value; }
        }
        public int NroDocumento
        {
            get { return nroDocumento; }
        }
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set {nacionalidad = value;}

        }


    }
}
