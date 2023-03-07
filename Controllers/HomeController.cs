using APIProduct.Data;
using APIProduct.Models;
using Microsoft.AspNetCore.Mvc;

namespace Porduct.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("produtos")]
        public ActionResult<List<Product>> Get([FromServices] AppDbContext context)
            => Ok(context.Products.ToList());

        [HttpGet]
        [Route("produtos/{id:int}")]
        public ActionResult GetById([FromRoute] int id, [FromServices] AppDbContext context)
        {
            var prod = context.Products.FirstOrDefault(x => x.Id_Produto == id);
            if (prod == null)
            {
                return NotFound();
            }
            return Ok(prod);

        }

        [HttpPost]
        [Route("produtos")]
        public ActionResult Post([FromBody] Product product, [FromServices] AppDbContext context)
        {
            context.Products.Add(product);
            context.SaveChanges();

            return Created($"/{product.Id_Produto}", product);
        }

        [HttpPut]
        [Route("produtos/{id:int}")]
        public ActionResult Put([FromRoute] int id, [FromBody] Product product, [FromServices] AppDbContext context)
        {
            var prod = context.Products.FirstOrDefault(x => x.Id_Produto == id);
            if (prod == null)
            {
                return NotFound();
            }

            prod.Nome_Produto = product.Nome_Produto;
            prod.Unidade_Medida = product.Unidade_Medida;
            prod.Foto_Produto = product.Foto_Produto;

            context.Products.Update(prod);
            context.SaveChanges();
            return Ok(prod);
        }

        [HttpDelete]
        [Route("produtos/{id:int}")]
        public ActionResult Delete([FromRoute] int id, [FromServices] AppDbContext context)
        {
            var prod = context.Products.FirstOrDefault(x => x.Id_Produto == id);
            if (prod == null)
            {
                return NotFound();
            }
            context.Products.Remove(prod);
            context.SaveChanges();
            return Ok(prod);
        }
    }
}