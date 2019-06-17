using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using Domain.Base;

namespace Domain.Entities
{
    public class Empleado : Entity<int>
    {
        public int Cedula { get; set; }
        public string Nombres { get; set; }
        public double SalarioBase { get; set; }
        public bool EsInterno { get; set; }

        public ICollection<Prima> Primas { get; set; }


        public double CalcularPrima(int periodo, DateTime fechaIncio, DateTime fechaFinal, double SalarioBase)
        {
            var tiempo = new DateTime(fechaIncio.Year, fechaFinal.Month, fechaFinal.Day) - fechaIncio;
            var dias = (fechaFinal.Month - fechaIncio.Month)*30;
            dias = dias - (31-fechaFinal.Day)-(31-fechaIncio.Day);
            double valorPrima = (SalarioBase*dias)/360;
            Prima prima = new Prima()
            {
                DiasTranscurridos = dias,
                FechaFinal = fechaFinal,
                FechaInicio = fechaIncio,
                SalarioBase = SalarioBase,
                Empleado = this,
                Valor = valorPrima,
                Periodo = periodo
            };
            Primas.Add(prima);
            return valorPrima;
        }
    }
}
