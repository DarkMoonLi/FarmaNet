using System.Collections.Generic;

namespace FarmaNetBackend.Models
{
    public class WorkerInformationImage
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }

        public WorkerInformation WorkerInformation { get; set; }


        public WorkerInformationImage()
        { }
    }
}
