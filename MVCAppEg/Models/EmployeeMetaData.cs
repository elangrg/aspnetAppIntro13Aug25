using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAppEg.Models
{
    public class EmployeeMetaData
    {
        [Required(ErrorMessage ="Employee Name must be Email ID and Required")]
        [StringLength(30)]
        [DisplayName("Employee First Name")]
        [DataType(DataType.EmailAddress)]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Employee Last Name")]
        public string LastName { get; set; }
        [Required]
       
        [Range (10000,1000000)]
       
        [DisplayName("Basic Salary")]
        public decimal Salary { get; set; }
    }

    [MetadataType(typeof(EmployeeMetaData) )]
    public partial class Employee
    { 
    
    
    }

    }