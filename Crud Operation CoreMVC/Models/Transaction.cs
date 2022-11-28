using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crud_Operation_CoreMVC.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage ="Account Number is mandatory")]
        [DisplayName("Account Number")]
        [MaxLength(20,ErrorMessage ="Maximum 15 characters only")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage ="Beneficiary Name is compulsory")]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage ="Bank Name is Required")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only")]
        [DisplayName("Swift Code")]
        [Required(ErrorMessage ="Code is compulsory")]
        public string SwiftCode { get; set; }


        [Required(ErrorMessage ="Enter your required Amount")]
        
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
