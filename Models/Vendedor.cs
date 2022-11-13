using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace tech_test_payment_api.Models
{
    public class Vendedor
    {
        
        [Key()]
        public int Id { get; set; }
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}