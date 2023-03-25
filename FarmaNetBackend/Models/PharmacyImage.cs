using System.Collections.Generic;

namespace FarmaNetBackend.Models
{
    public class PharmacyImage
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }

        public Pharmacy Pharmacy { get; set; }


        public PharmacyImage()
        { }
    }
}
