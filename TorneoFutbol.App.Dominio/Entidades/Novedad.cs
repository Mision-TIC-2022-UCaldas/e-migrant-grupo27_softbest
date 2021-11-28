using System;
using System.Collections.Generic;

namespace TorneoFutbol.App.Dominio
{
    public class Novedad
    {
        public int Id{get; set;}
        public DateTime Fecha_Novedad{get; set;}
        public int Dias_Activo{get; set;}
        public string Descripcion{get; set;}


    }
}