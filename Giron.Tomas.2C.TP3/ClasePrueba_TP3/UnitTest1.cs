using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaInstanciable_TP3;
using EntidadesAbstractas;
using Excepciones_TP3;

namespace ClasePrueba_TP3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void ValidateFirstException()
        {
            Universidad uni = new Universidad();
            Alumno a2 = new Alumno(2, "Juana", "Martinez", "12234458",
               EntidadesAbstractas.Persona.ENacionalidad.Extranjero, Universidad.EClases.Laboratorio,
               Alumno.EEstadoCuenta.Deudor);
            uni += a2;
        }

        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void ValidateSecondException()
        {
            Universidad uni = new Universidad();
            Alumno a1 = new Alumno(1, "Juan", "Lopez", "12234456",
                EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.SPD,
                Alumno.EEstadoCuenta.AlDia);
            uni += a1;
            Alumno a3 = new Alumno(3, "José", "Gutierrez", "12234456",
               EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.SPD,
               Alumno.EEstadoCuenta.AlDia);
            uni += a3;
        }

        [TestMethod]
        public void ValidateCollectionNotNull()
        {
            Universidad uni = new Universidad();
            Profesor profe = new Profesor();
            uni += profe;
            Assert.IsNotNull(uni.Profesores);
        }
    }
}
