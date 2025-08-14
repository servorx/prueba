using System.Collections.Generic;
using QuestPDF.Fluent;

namespace prueba;
public class PdfService
{
    public void GenerarResumido(List<Variedad> variedades, string rutaSalida)
    {
        var doc = new VariedadesResumidasPdfDocument(variedades);
        doc.GeneratePdf(rutaSalida);
    }

    public void GenerarDetallado(List<Variedad> variedades, string rutaSalida)
    {
        var doc = new VariedadesDetalladasPdfDocument(variedades);
        doc.GeneratePdf(rutaSalida);
    }
}
