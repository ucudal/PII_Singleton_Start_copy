using System.IO;
using Library;
using NUnit.Framework;

namespace LibraryTests
{
    public class Tests
    {
        /// <summary>
        /// Prueba el comportamiento de <see cref="Greeter.SayHiToTheWorld"/> usando un singleton. Como el método escribe
        /// en la consola, para "ver" lo que se escribe en la consola es necesario "redirigir" la salida en la consola
        ///  utilizando <see cref="System.Console.SetOut(TextWriter)"/> a un <see cref="StringWriter"/>.
        /// </summary>
        [TestCase("Hello World!\r\n")]
        [TestCase("Hello World!\n")]
        public void TestSayHiToTheWorld(string expected)
        {
            using (StringWriter sw = new StringWriter())
            {
                System.Console.SetOut(sw);
                Singleton<Greeter>.GetInstance().SayHiToTheWorld();
                Assert.That(sw.ToString(), Is.EqualTo(expected));
            }
        }
    }
}