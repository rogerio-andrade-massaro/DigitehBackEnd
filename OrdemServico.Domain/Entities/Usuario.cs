﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrdemServico.Domain
{
    [Table("Usuarios")]
    public class Usuario
    {
        public string Email { get; set; }
        public string Password { get; set; }
        
    }
}
