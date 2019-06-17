using Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Test
{
    [TestFixture]
    public class EmpleadoTest
    {
        /// <summary>
        /// ---fechas validas---
        /// /dado que el empleado ingresa una fecha de inicio 2019/02/01
        /// con un salario basico de 1000000 en el periodo 1 sin auxilio de transporte
        /// el sistema retornar el valor de 000000
        /// </summary>
        [Test]
        public void TestFechasValidas()
        {
            // TODO: Add your test code here
            var fechaIncicio = new DateTime(2019, 02, 01);
            var fechaaFin = new DateTime(2019, 06, 30);

            int periodo = 1;
            bool esInterno = false;
            double salarioBasico = 1000000;

            var empleado = new Empleado()
            {
                Cedula = 12345678,
                Nombres = "juanito perez",
                SalarioBase = salarioBasico,
                EsInterno = esInterno
            };

            empleado.CalcularPrima(periodo, fechaIncicio, fechaaFin, salarioBasico);
            var answer = 23;

            Assert.That(answer, Is.EqualTo(42), "Some useful error message");
        }
    }
}
