using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.ViewModels
{
    public class CreateCommentViewModel
    {
        [Display(Name = "Text")]
        [Required(ErrorMessage = "Enter a text")]
        public string Text { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Enter a name")]
        public string Name { get; set; }
    }
}
