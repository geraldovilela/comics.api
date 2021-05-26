using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace comics.api.Data.Entities
{
    public class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}

        [Timestamp]
        public DateTime Created_at { get; set; }

        [Timestamp]
        public DateTime Updated_at { get; set; }

        public Entity()
        {
            Created_at = DateTime.Now;
            Updated_at = DateTime.Now;
        }
    }
}
