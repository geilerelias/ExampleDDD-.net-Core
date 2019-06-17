using System;
using System.Collections.Generic;
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

        public List<Prima> Primas { get; set; }


        public double CalcularPrima(int perido, DateTime fechaIncio, DateTime fechaFinal, double SalarioBase)
        {
            Prima prima = new Prima();
            var tiempo = new DateTime(fechaIncio.Year, fechaFinal.Month, fechaFinal.Day) - fechaIncio;
            if (perido == 1)
            {
                var meses= fechaFinal.Month - fechaIncio.Month;
                meses = meses * 30;


            }
            else
            {

            }
            return 0;
        }
    }
}
