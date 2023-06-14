using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryMengament.Models
{
    [MetadataType(typeof(bookMetaData))]
    public partial class book
    {
        public class bookMetaData
        {
            [Required]
            [DisplayName("Book Name")]
            public string bname { get; set; }
            [Required]
            [DisplayName("Category ID")]
            public Nullable<int> lcat_id { get; set; }
            [Required]
            [DisplayName("Author ID")]
            public Nullable<int> a_id { get; set; }
            [Required]
            [DisplayName("Publisher ID")]
            public Nullable<int> p_id { get; set; }
            [Required]
            [DisplayName("Contents")]
            public string contents { get; set; }
            [Required]
            [DisplayName("Number of pages")]
            public Nullable<int> pages { get; set; }
            [Required]
            [DisplayName("Edition")]
            public string edition { get; set; }
        }
    }
}