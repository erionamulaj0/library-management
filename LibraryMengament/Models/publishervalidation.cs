using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static LibraryMengament.Models.author;

namespace LibraryMengament.Models
{
    [MetadataType(typeof(publisherMetaData))]
    public partial class publisher
    {
        public class publisherMetaData
        {
            [DisplayName("Publisher Name")]
            public string name { get; set; }

            [DisplayName("Address")]
            public string address { get; set; }

            [DisplayName("Phone")]
            public string phone { get; set; }
        }
    }
}