using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class FullName
    {

       [MinLength(3, ErrorMessage ="longeur minimal 3 !!")]
       [MaxLength(25 , ErrorMessage ="longeur maximal 25 !!")]
       public string?  FirstName{ get; set; }

       public string? LastName { get; set; }
    }
}
