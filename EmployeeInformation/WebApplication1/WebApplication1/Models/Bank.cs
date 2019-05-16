using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Bank
    {

        [Key]

        public int AccountNumber { get; set; }

        [Display(Name = "Current Balance")]

        [DataType(DataType.Currency)]

        public double Amount { get; set; }

        [Display(Name = "Account Type")]

        public string AccountType { get; set; }

        [Display(Name = "Account Holder's Name")]

        public string AccHoldersName { get; set; }

        [Display(Name = "Email")]

        [DataType(DataType.EmailAddress)]

        public string EmailId { get; set; }

        public string Address { get; set; }

        public long Contact { get; set; }

        [Display(Name = "Date Of Birth")]

        [DataType(DataType.Date)]

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime DOB { get; set; }

        [Display(Name = "Account Creation Date")]

        [DataType(DataType.Date)]

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime CreationDate { get; set; }
    }
}