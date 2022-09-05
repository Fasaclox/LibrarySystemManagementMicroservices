using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMCustomerMicroserviceApi.Model
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Customer_Id { get; set; }
        public int Staff_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string? Middle_Name { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }
        public string Phone_Number { get; set; }
        public string Email { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime? Date_Edited { get; set; }
        public DateTime? Date_Deleted { get; set; }

    }
}
