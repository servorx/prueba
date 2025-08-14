using System.Collections.Generic;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace prueba;

public class VariedadesDetalladasPdfDocument : IDocument
{
    // esto lo que hace es mostrar todas las variedad incluyendo todos los detalles posibles, incluso los de las clases de HistoriaGenetica y AtributoAgronomo
    private readonly List<Variedad> _variedades;

    public VariedadesDetalladasPdfDocument(List<Variedad> variedades)
    {
        _variedades = variedades;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Margin(30);
            page.Header().Text("Catálogo Detallado de Variedades").FontSize(20).Bold().AlignCenter();

            page.Content().Column(col =>
            {
                foreach (var v in _variedades)
                {
                    col.Item().Row(row =>
                    {
                        row.ConstantItem(120).Image(Placeholders.Image(120, 120)); // o .Image(v.ImagenUrl)

                        row.RelativeItem().Column(c =>
                        {
                            c.Item().Text(v.Nombre).FontSize(16).Bold();
                            c.Item().Text($"Altitud: {v.Altitud}");
                            c.Item().Text($"Tamaño de grano: {v.TamanoGrano}");
                            c.Item().Text($"Porte: {v.Porte}");
                            c.Item().Text($"Rendimiento: {v.Rendimiento}");
                            c.Item().Text($"Resistencia: {v.Resistencia}");
                            c.Item().Text($"Calidad: {v.Calidad}");
                            c.Item().Text($"Descripción: {v.Descripcion}").Italic();
                        });
                    });

                    col.Item().PaddingVertical(8).LineHorizontal(1f);
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
