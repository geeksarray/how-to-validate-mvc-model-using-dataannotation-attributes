using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;  

namespace FirstMVC.Models
{
    public class Customer
    {
        [Required(ErrorMessage="Customer ID is required")]        
        public string CustomerID { get; set; }

        [StringLength(10, ErrorMessage = "Company Name should be less than or equal to ten characters.")]        
        public string CompanyName { get; set; }

        [Range(20,40, ErrorMessage="Customer Age should be in 20 to 40 range." )]   
        public int Age { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime JoinDate { get; set; }
        
        [DataType(DataType.EmailAddress,ErrorMessage="Email is not valid." )]  
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",ErrorMessage="Email is not valid.")]  
        public string Email { get; set; }        
        
        [EnumDataType
            (typeof(EnumCustomerType))]  
        public EnumCustomerType CustomerType { get; set; }
    }

    public enum EnumCustomerType
    {
        New = 0,
        Regular = 1,
        Elite = 2
    }
}