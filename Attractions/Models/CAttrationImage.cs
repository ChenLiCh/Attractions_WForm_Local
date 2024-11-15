using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attractions.Models {
    public class CAttrationImage {
        public int fAttractionImageId { get; set; }
        public int fAttractionId { get; set; }
        public List<byte[]> fImage { get; set; }
    }
}
