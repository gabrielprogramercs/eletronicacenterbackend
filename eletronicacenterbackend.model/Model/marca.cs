using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eletronicacenterbackend.model.Model
{
    [Table("marca")]
    public class marca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idmarca { get; set; }
        public string description { get; set; }
    }
}
