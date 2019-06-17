using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Domain.Base;

namespace Domain.Entities
{
    public class Prima : Entity<int>
    {
        public int Periodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int DiasTranscurridos { get; set; }
        public double SalarioBase { get; set; }
        public double Valor { get; set; }
        

        [Display(Name = "Empleado")]
        public int EmpleadoId { get; set; }

        [ForeignKey("EmpleadoId")]
        public virtual Empleado Empleado { get; set; }


        const double AUXILIOTRANSPORTE = 2771;




    }
}
