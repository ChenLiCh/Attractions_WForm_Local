using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attractions.Models {
    public class CAttraction {
        public int fAttractionId {  get; set; }
        public string fAttractionName { get; set; }
        public string fDescription { get; set; }
        public string fAddress {  get; set; }
        public string fPhoneNumber { get; set; }
        public TimeSpan fOpeningTime { get; set; }
        public TimeSpan fClosingTime { get; set; }
        public string fWebsiteURL {  get; set; }
        public string fLongitude { get; set; }
        public string fLatitude { get; set; }
        public string fRegion { get; set; }
        public int fCategoryId { get; set; }
        public string fCategoryName { get; set; }
        public DateTime fCreatedDate { get; set; }
        public DateTime fUpdatedDate { get; set; }
        public string fStatus {  get; set; }
        public string fTransformInformation { get; set; }
    }
}
