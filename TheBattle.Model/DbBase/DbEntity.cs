using System.ComponentModel.DataAnnotations;

namespace TheBattle.Model.DbBase
{
    public class DbEntity<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
