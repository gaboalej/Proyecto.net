﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulos
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int IdMarca { get; set; }

        public int IdCategoria {get; set;}

        public string ImagenUrl { get; set; }

        public decimal Precio { get; set; }

        public Marcas Marca { get; set; }

        public Categoria categoria { get; set; }











    }
}
