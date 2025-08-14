using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba;
public interface IVariedadPdfService
{
    // esto como tal es para generar un pdf con un template en especfico, se usa byte porque el template puede ser de cualquier tipo y no se van a usar mas de 255 plantillas 
    byte[] GenerarPdf<TTemplate>(TTemplate template) where TTemplate : IVariedadPdfTemplate;
}
