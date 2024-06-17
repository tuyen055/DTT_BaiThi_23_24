using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTT_BaiThi_23_24.Models{
    [Table("Person")]
    public class Person{
        [Key]
        public int PersonID { get; set; }
        public string PersonName { get; set; }
        public DateOnly Birthday { get; set; }
    
}
}