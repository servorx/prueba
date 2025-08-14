using System.Collections.Generic;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace prueba;

public class VariedadesResumidasPdfDocument : IDocument
{
    private readonly List<Variedad> _variedades;

    public VariedadesResumidasPdfDocument(List<Variedad> variedades)
    {
        _variedades = variedades;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Margin(30);
            page.Header().Text("Catálogo Resumido de Variedades").FontSize(20).Bold().AlignCenter();

            page.Content().Column(col =>
            {
                foreach (var v in _variedades)
                {
                    col.Item().Row(row =>
                    {
                        row.ConstantItem(80).Image(Placeholders.Image(80, 80)); // reemplaza por .Image(v.ImagenUrl) si usas rutas reales
                        row.RelativeItem().Column(c =>
                        {
                            c.Item().Text(v.Nombre).Bold();
                            c.Item().Text($"Altitud: {v.Altitud}");
                            c.Item().Text($"Porte: {v.Porte}");
                            c.Item().Text($"Tamaño de grano: {v.TamanoGrano}");
                            c.Item().Text($"Calidad: {v.Calidad}");
                        });
                    });
                    col.Item().LineHorizontal(0.5f);
                }
            });

            page.Footer().AlignCenter().Text(t =>
            {
                t.Span("Página ");
                t.CurrentPageNumber();
                t.Span(" de ");
                t.TotalPages();
            });
        });
    }
}
