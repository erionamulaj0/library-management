using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryMengament.Models
{
    [MetadataType(typeof(lcategoryMetaData))]
    public partial class lcategory
    {
        public class lcategoryMetaData
        {
            [DisplayName("Category Name")]
            [Required]
            public string catname { get; set; }


            [DisplayName("Status")]
            [Required]
            public string status { get; set; }
        }
    }
}