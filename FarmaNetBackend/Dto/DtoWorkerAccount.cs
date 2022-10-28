using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaNetBackend.Dto
{
    public class DtoWorkerAccount
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int IdWorkerInformation { get; set; }
        public int IdPharmacy { get; set; }
    }
}
