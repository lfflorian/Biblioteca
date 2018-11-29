using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Biblioteca.Controllers
{
    public class DocumentoController : ApiController
    {
        Documento documento = new Documento();

        [HttpGet]
        public Documento ObtenerDocumento(int id)
        {
            documento.Id = id;
            return documento.BuscarDocumento();
        }

        [HttpGet]
        public void ObtenerDocumentos()
        {
            documento.DevolverDocumentos();
        }
    }
}
