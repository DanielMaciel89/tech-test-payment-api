using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace tech_test_payment_api.Models
{
    public class Vendas 
    {

        [Key()]
        public int Id { get; set; }

        //  public Vendas(int id, int idVendedor, int cpf, string nome, string email, string telefone)
        // {
        //     Id = id;
        //     IdVendedor = idVendedor;
        //     Cpf = cpf;
        //     Nome = nome;
        //     Email=email;
        //     Telefone=telefone;

        // }
        [ForeignKey("Vendedor")]
        public int IdVendedor { get; set; }
        public virtual Vendedor Vendedor {get;set;}
        public string Itens{get;set;}
        public DateTime Data{get;set;}


        
        
        
        
    }
}