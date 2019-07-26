using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DVL_Test.WebUI.Models
{
    public class WordMetaData
    {
        public int WordId { get; set; }
        [Display(Name="dfdfd")]
        public string Text { get; set; }
    }
}