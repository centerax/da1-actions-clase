namespace CalculadoraStringsTest;

using Dominio;

[TestClass]
public class CalculadoraStringsTest
{
    private Calculadora unaCalculadora;
    
    [TestInitialize]
    public void CrearCalculadora()
    {
        this.unaCalculadora = new Calculadora();
    }
    
    //DataRow
    [TestMethod]
    [DataRow("3", 3, DisplayName = "Sumar string: 3")]
    [DataRow("7", 7, DisplayName = "Sumar string: 7")]
    [DataRow("", 0, DisplayName = "Sumar string vacío.")]
    public void PruebaClaseStrings(string entrada, int resultadoEsperado)
    {
        //Act
        int resultado = this.unaCalculadora.Sumar(entrada);

        //Assert
        Assert.AreEqual(resultadoEsperado, resultado);
    }
    
}