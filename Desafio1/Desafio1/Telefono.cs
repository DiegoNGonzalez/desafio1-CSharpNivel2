﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Telefono
    {
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        public Telefono(string modelo, string marca) 
        {
            this.modelo = modelo;
            this.marca = marca;
            numeroTelefonico = "1167215232";

        }

        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca
        {
            get { return marca; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }

        }
        public int CodigoOperador 
        {
            get { return codigoOperador; }
            set
            {
                if(value > 0 && value < 4)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }
        public string Llamar()
        {
            return "Realizando llamada...";
        }
        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }
    }
}
