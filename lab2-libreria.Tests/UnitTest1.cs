namespace lab2_libreria.Tests;
using NUnit.Framework;
using lab2_libreria;

public class Tests
{
    private Libreria libreria;
    [SetUp]
    public void Setup()
    {
        libreria = new Libreria();
    }

    [Test]
    public void AgregarLibro_BlankOrNullBook_ThrowExceptionIllegalArgument()
    {
        Assert.Throws<ArgumentException>(() => libreria.AgregarLibro(null));
        Assert.Throws<ArgumentException>(() => libreria.AgregarLibro(""));
    }
    
    [Test]
    public void AgregarLibro_ValidBook_AddBook()
    {
        libreria.AgregarLibro("El Quijote");
        Assert.IsTrue(libreria.libros.Contains("El Quijote"));
    }
    
    [Test]
    public void BuscarLibro_BlankOrNullBook_ThrowExceptionIllegalArgument()
    {
        Assert.Throws<ArgumentException>(() => libreria.BuscarLibro(null));
        Assert.Throws<ArgumentException>(() => libreria.BuscarLibro(""));
    }

    [Test]
    public void BuscarLibro_ValidBook_ReturnTrue()
    {
        libreria.AgregarLibro("El Quijote");
        Assert.IsTrue(libreria.BuscarLibro("El Quijote"));
    }

    [Test]
    public void AgregarYBuscarLibro_ValidBook_ReturnTrue()
    {
        libreria.AgregarLibro("El Quijote");
        Assert.IsTrue(libreria.BuscarLibro("El Quijote"));
    }
    
    [Test]
    public void AgregarYBuscarLibro_BlankOrNullBook_ThrowExceptionIllegalArgument()
    {
        Assert.Throws<ArgumentException>(() => libreria.AgregarLibro(null));
        Assert.Throws<ArgumentException>(() => libreria.AgregarLibro(""));
        Assert.Throws<ArgumentException>(() => libreria.BuscarLibro(null));
        Assert.Throws<ArgumentException>(() => libreria.BuscarLibro(""));
    }
}