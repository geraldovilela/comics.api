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
        /// <summary>
        /// Id Primary key de todas as tabelas.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        /// <summary>
        /// Data de Criação do registro.
        /// </summary>
        [Timestamp]
        public DateTime Created_at { get; set; }
        /// <summary>
        /// Data de update do registro.
        /// </summary>
        [Timestamp]
        public DateTime Updated_at { get; set; }

        public Entity()
        {
            Created_at = DateTime.Now;
            Updated_at = DateTime.Now;
        }
    }
}
