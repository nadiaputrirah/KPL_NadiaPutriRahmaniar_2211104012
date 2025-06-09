using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace modul14_2211104012.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        // Model Mahasiswa
        public class Mahasiswa
        {
            public string Nama { get; set; }
            public string Nim { get; set; }
        }

        // List statis data mahasiswa
        private static readonly List<Mahasiswa> _mahasiswaList = new()
        {
            new Mahasiswa { Nama = "Nadia Putri Rahmaniar", Nim = "2211104012" },
            new Mahasiswa { Nama = "Nita Fitrotul Mar'ah", Nim = "2211104005" },
            new Mahasiswa { Nama = "Alfian Mutakim", Nim = "2211104020" },
            new Mahasiswa { Nama = "Edgar Nadhif", Nim = "2211104021" },
            new Mahasiswa { Nama = "Dhimas Afrizal", Nim = "22111040019" }
        };

        // GET: api/mahasiswa
        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAllMahasiswa()
        {
            return Ok(_mahasiswaList);
        }

        // GET: api/mahasiswa/{id}
        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> GetMahasiswaById(int id)
        {
            if (id < 0 || id >= _mahasiswaList.Count)
            {
                return NotFound();
            }

            return Ok(_mahasiswaList[id]);
        }

        // POST: api/mahasiswa
        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa mahasiswa)
        {
            _mahasiswaList.Add(mahasiswa);
            return CreatedAtAction(nameof(GetMahasiswaById), new { id = _mahasiswaList.Count - 1 }, mahasiswa);
        }

        // DELETE: api/mahasiswa/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteMahasiswa(int id)
        {
            if (id < 0 || id >= _mahasiswaList.Count)
            {
                return NotFound();
            }

            _mahasiswaList.RemoveAt(id);
            return NoContent();
        }
    }
}