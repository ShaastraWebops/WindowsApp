using System.Collections.Generic;

namespace Shaastra.Events
{
    public class EventsCategoryModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public string Imageid { get; set; }
        public string Imagename { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string LastUpdatedBy { get; set; }
        public int V { get; set; }
        public List<object> Events { get; set; }
    }
}
