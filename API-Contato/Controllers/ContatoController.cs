using API_Contato.Context;
using API_Contato.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API_Contato.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")]
        public IActionResult GetResultForId(int id)
        {
            var contato = _context.Contatos.Find(id);

            if(contato == null)
                return NotFound();
            
            return Ok(contato);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult GetResultForName(string nome)
        {
            var contatos = _context.Contatos.Where(contact => contact.Nome.Contains(nome));

            return Ok(contatos);
        }

        [HttpPut("{id}")]
        public IActionResult EditInfoForId(int id, Contato contato)
        {
            var contatoEdit = _context.Contatos.Find(id);

            if (contatoEdit == null)
                return NotFound();
            
            contatoEdit.Nome = contato.Nome;
            contatoEdit.Telefone = contato.Telefone;
            contatoEdit.Ativo = contato.Ativo;

            _context.SaveChanges();
            return Ok(contatoEdit);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteInfoForId(int id)
        {
            var contatoDelete = _context.Contatos.Find(id);

            if (contatoDelete == null)
                return NotFound();
            
            _context.Contatos.Remove(contatoDelete);
            _context.SaveChanges();

            return NoContent();
        }
    }
}