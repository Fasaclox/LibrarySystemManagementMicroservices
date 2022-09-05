using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMBorrowerMicroserviceApi.Model
{
    [Table("Borrowers")]
    public class Borrower
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Borrower_Id { get; set; }
        public int Customer_Id { get; set; }
        public int Staff_Id { get; set; }
        public int BookISBN_Id { get; set; }
        public bool Is_Borrowed { get; set; }
        public DateTime Date_Borrowed { get; set; }
        public DateTime Date_Expected_Return { get; set; }
        public int Count_Book_Borrowed { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime? Date_Edited { get; set; }
        public DateTime? Date_Deleted { get; set; }

    }
}
