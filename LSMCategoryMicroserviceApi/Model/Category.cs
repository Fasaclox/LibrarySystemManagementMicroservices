using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMCategoryMicroserviceApi.Model
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime? Date_Edited { get; set; }
        public DateTime? Date_Deleted { get; set; }
    }
}
