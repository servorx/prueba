using System;
using System.Collections.Generic;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace prueba;

public class Program
{
    public static void Main()
    {
        QuestPDF.Settings.License = LicenseType.Community;

        var variedades = new List<Variedad>
        {
            new()
            {
                Nombre = "Caturra",
                Altitud = "1200-1800 msnm",
                TamanoGrano = "Mediano",
                Porte = "Bajo",
                Rendimiento = "Alto",
                Resistencia = "Moderada",
                Calidad = "Alta",
                Descripcion = "Variedad popular por su buena taza y productividad."
            },
            new()
            {
                Nombre = "Bourbon",
                Altitud = "1000-1600 msnm",
                TamanoGrano = "Grande",
                Porte = "Medio",
                Rendimiento = "Medio",
                Resistencia = "Baja",
                Calidad = "Premium",
                Descripcion = "Sabor dulce y aromático, muy apreciado en especialidad."
            }
        };

        new VariedadesResumidasPdfDocument(variedades).GeneratePdf("Variedades_Resumido.pdf");
        new VariedadesDetalladasPdfDocument(variedades).GeneratePdf("Variedades_Detallado.pdf");

        Console.WriteLine("PDFs generados.");
    }
}
