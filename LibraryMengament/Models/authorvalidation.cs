using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static LibraryMengament.Models.lcategory;

namespace LibraryMengament.Models
{
    [MetadataType(typeof(authorMetaData))]
    public partial class author
    {

        public class authorMetaData
        {
            [DisplayName("Author Name")]
            public string name { get; set; }

            [DisplayName("Address")]
            public string address { get; set; }
            
            [DisplayName("Phone")]
            public string phone { get; set; }
        }
    }
}