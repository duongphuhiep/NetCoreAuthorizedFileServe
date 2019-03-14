using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace NetCoreTuto2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpGet("{path}")]
        public IActionResult Get(string path)
        {
            var fi = new FileInfo(path);
            var bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, "application/octet-stream", fi.Name);
        }

        // public async Task<IActionResult> Download(string id)
        // {
        //     Stream stream = await { { __get_stream_based_on_id_here__} }
        //     if (stream == null)
        //         return NotFound();
        //     return File(stream, "application/octet-stream"); // returns a FileStreamResult
        // }
    }
}
