using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca_TP4;

namespace Prueba_TP4
{
    [TestClass]
    public class UnitTest_TP4
    {
        [TestMethod]
        public void ListaPaquetesInstanciadaTest()
        {
            //Arrange
            Correo mailbox = new Correo();

            //Act


            //Assert
            Assert.IsNotNull(mailbox.Paquetes);

        }

        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void PaqueteRepetidoTest()
        {
            //Arrange
            Correo mailbox = new Correo();
            Paquete p1 = new Paquete("Tailandia", "04K-L3");
            Paquete p2 = new Paquete("Japon", "04K-L3");

            //Act
            mailbox += p1;
            mailbox += p2;

            //Assert - no hay porque se espera la excepcion


        }
    }
}
