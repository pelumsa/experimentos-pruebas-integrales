namespace lab2_libreria;

public class Libreria
{
    public List<string> libros;
    public Libreria()
    {
        libros = new List<string>();
    }

    public void AgregarLibro(string libro)
    {
        if (libro != null && libro != "")
        {
           libros.Add(libro);
        }
    }

    public bool BuscarLibro(string libro)
    {
        if (libro != null && libro != "")
        {
            return libros.Contains(libro);
        }
        return false;
    }
}
