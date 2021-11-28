using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
namespace TorneoFutbol.App.Dominio
{
     
    public class Necesidad
    {
        public int Id { get; set; }

        public string Nombre_Nesesidad{get; set;}
        
        public string Descripcion { get; set; }

        public Prioridad Prioridad { get; set; }

        public Migrante Migrante {get; set;}

        public Entidad Entidad {get; set;}
        
        
    }
}