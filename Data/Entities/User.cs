using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace comics.api.Data.Entities
{
    public class User : Entity
    {
        /// <summary>
        /// campo para o nome do usuario no cadastro;
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// email chave unica usada para login no sistema;
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// senha crypto grafada do usuario;
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Guid para exposição e requests mais seguras;
        /// </summary>
        
        public Guid Guid { get; set; }

    }
}
