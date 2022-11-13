using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tech_test_payment_api.Context;
using tech_test_payment_api.Models;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController:ControllerBase
    {
    
    private readonly VendasContext _context; 

    public VendaController(VendasContext context)
    {
        _context = context;
    }
    [HttpPost]
    public IActionResult Criar(Vendas venda)
    {
        _context.Add(venda);
         return Ok(venda);
    }

    [HttpGet("VendasConcluidas")]
    public IActionResult VendasConcluidas(int id)
    {
        var vendas = _context.Vendas.Find(id);

        if(vendas == null)
        return NotFound();
        return Ok(vendas);
    }

    }
}