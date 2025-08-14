using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuestPDF.Fluent;

namespace prueba;
public class VariedadPdfService : IVariedadPdfService
{
    public byte[] GenerarPdf<TTemplate>(TTemplate template) where TTemplate : IVariedadPdfTemplate
    {
        // generar pdf trabaja con el IDocument que se encuentra en la interfaz de template
        return template.GeneratePdf();
    }
}
