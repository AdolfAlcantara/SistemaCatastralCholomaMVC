﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaCatastralCholoma.Models
{

    public class Predio
    {
        [Required]
        [StringLength(50)]
        public string id { get; set; }
        public string numeroPredio {get;set;}
        public string barrio { get; set; }
        public string caserio { get; set; }
        public USO uso { get; set; }
        public SUBUSO subUso { get; set; }
        public string sitio { get; set; }
        public string construccion {get;set;}
        public ESTATUS_TRIBUTARIO estatusTributario {get;set;}
        public string codigoPropietario {get;set;}
        public string codigoHabitacional {get;set;}
        public double porcentajeExencion {get;set;}
        public double tasaImpositiva {get;set;}
        public int futurasRevisiones {get;set;}
        public double porcentajeConcertacion {get;set;}


        public Predio(string id, string numeroPredio, string barrio, string caserio, USO uso, SUBUSO subUso, string sitio,
                      string construccion, ESTATUS_TRIBUTARIO estatusTributario, string codigoPropietario,
                      string codigoHabitacional, double porcentajeExencion, double tasaImpositiva, int futurasRevisiones,
                      double porcentajeConcertacion)
        {
            this.id = id;
            this.numeroPredio = numeroPredio;
            this.barrio = barrio;
            this.caserio = caserio;
            this.uso = uso;
            this.subUso = subUso;
            this.sitio = sitio;
            this.construccion = construccion;
            this.estatusTributario = estatusTributario;
            this.codigoPropietario = codigoPropietario;
            this.codigoHabitacional = codigoHabitacional;
            this.porcentajeExencion = porcentajeExencion;
            this.tasaImpositiva = tasaImpositiva;
            this.futurasRevisiones = futurasRevisiones;
            this.porcentajeConcertacion = porcentajeConcertacion;
        }

        public Predio()
        {
        }
    }


}