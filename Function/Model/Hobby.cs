using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Function.Model
{
    [Table("hobbies")]
    public class Hobby
    {
        [Key, Column("hobby_id")]
        public int Id { get; set; }
        [Column("hobby")]
        public string Name { get; set; }
    }
}