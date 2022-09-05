using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMBookMicroserviceApi.Model
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookISBN_Id { get; set; }
        public int Binding_Id { get; set; }
        public int Category_Id { get; set; }
        public int Shelf_Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }
        public string Language { get; set; }
        public DateTime Year_Published { get; set; }
        public int Number_Actual_Copies { get; set; }
        public int Number_Current_Copies { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime? Date_Edited { get; set; }
        public DateTime? Date_Deleted { get; set; }
    }
}
