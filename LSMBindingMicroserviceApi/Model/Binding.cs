using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LSMBindingMicroserviceApi.Model
{
    [Table("Bindngs")]
    public class Binding
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Binding_Id { get; set; }
        public string Binding_Name { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime? Date_Edited { get; set; }
        public DateTime? Date_Deleted { get; set; }
    }
}
