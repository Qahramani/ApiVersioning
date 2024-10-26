//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace TestApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ValuesController : ControllerBase
//    {
//        private readonly IWebHostEnvironment _webHostEnvironment;

//        public ValuesController(IWebHostEnvironment webHostEnvironment)
//        {
//            _webHostEnvironment = webHostEnvironment;
//        }

//        [HttpGet("GetAll")]
//        public IActionResult GetAll()
//        {
//            return Ok();
//        }

//        [HttpGet("{id?}")]
//        public IActionResult Get(int? id)
//        {
//            return Ok();
//        }

//        [HttpPost("Upload")]
//        public async Task<IActionResult> Upload(IFormFile file)
//        {
//            var path = Path.Combine(_webHostEnvironment.WebRootPath, "images");

//            if (!Directory.Exists(path))
//            {
//                Directory.CreateDirectory(path);
//            }

//            path = Path.Combine(path, file.FileName);

//            using (var fs = new FileStream(path, FileMode.Create))
//            {
//                await file.CopyToAsync(fs);
//            }

//            return Ok();
//        }

//        [HttpGet("Download/{filename}")]
//        public IActionResult Download(string filename)
//        {
//            if (filename == null) return NotFound();

//            var path = Path.Combine(_webHostEnvironment.WebRootPath, "images", filename);

//            if (!System.IO.File.Exists(path)) return NotFound();

//            var bytes = System.IO.File.ReadAllBytes(path);

//            return File(bytes, "application/pptx", filename);
//        }
//    }
//}
