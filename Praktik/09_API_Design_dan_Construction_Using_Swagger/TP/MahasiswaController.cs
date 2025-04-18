using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tp_modul9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public class Mahasiswa
        {
            public string Nama { get; set; }
            public string Nim { get; set; }
        }

        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Nita Fitrotul Mar'ah", Nim = "2211104005" },
            new Mahasiswa { Nama = "Alfian Mutakim", Nim = "2211104017" },
            new Mahasiswa { Nama = "Nadia Putri Rahmaniar", Nim = "2211104012" },
            new Mahasiswa { Nama = "Rafli Dafin Kamil", Nim = "2211104023" },
            new Mahasiswa { Nama = "Muhammad Edgar Nadhif", Nim = "22111040028" },
            new Mahasiswa { Nama = "Muhammad Dhimas Afrizal", Nim = "22111040025" },
        };

        // GET /api/mahasiswa
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        // GET /api/mahasiswa/{id}
        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Get(int id)
        {
            if (id < 0 || id >= listMahasiswa.Count)
                return NotFound();
            return listMahasiswa[id];
        }

        // POST /api/mahasiswa
        [HttpPost]
        public void Post([FromBody] Mahasiswa mhs)
        {
            listMahasiswa.Add(mhs);
        }

        // DELETE /api/mahasiswa/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id >= 0 && id < listMahasiswa.Count)
            {
                listMahasiswa.RemoveAt(id);
            }
        }
    }
}