namespace prueba;

public class Variedad
{
    public string Nombre { get; set; } = "";
    public string ImagenUrl { get; set; } = "";
    public string Altitud { get; set; } = "";
    public string TamanoGrano { get; set; } = "";
    public string Porte { get; set; } = "";
    public string Rendimiento { get; set; } = "";
    public string Resistencia { get; set; } = "";
    public string Descripcion { get; set; } = "";
    public string Calidad { get; set; } = "";
    // crear constructor con parametros
    public Variedad()
    { 
        
    }
    public Variedad(string nombre, string imagenUrl, string altura, string tamanoGrano, string porte, string rendimiento, string resistencia, string descripcion, string calidad)
    {
        Nombre = nombre;
        ImagenUrl = imagenUrl;
        Altitud = altura;
        TamanoGrano = tamanoGrano;
        Porte = porte;
        Rendimiento = rendimiento;
        Resistencia = resistencia;
        Descripcion = descripcion;
        Calidad = calidad;
    }
}
