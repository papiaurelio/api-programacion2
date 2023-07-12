using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiMercado.Controllers
{
    public class ClientesController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            List<ViewModels.ClienteViewModel> list =
             new List<ViewModels.ClienteViewModel>();

            using (Models.MercadoEntities1 db = new Models.MercadoEntities1())
            {
                list = (from c in db.Clientes
                        select new ViewModels.ClienteViewModel
                        {
                            Id = c.Id,
                            Nombre = c.Nombre,
                            Apellido = c.Apellido,
                            Telefono = c.Telefono

                        }).ToList();
            }
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            ViewModels.ClienteViewModel cliente = null;
            using (Models.MercadoEntities1 db =
                new Models.MercadoEntities1())
            {
                cliente = db.Clientes.Where(c => c.Id == id)
                    .Select(c => new ViewModels.ClienteViewModel()
                    {
                        Id = c.Id,
                        Nombre = c.Nombre,
                        Apellido = c.Apellido,
                        Telefono = c.Telefono

                    }).FirstOrDefault<ViewModels.ClienteViewModel>();
            }
            if (cliente == null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpPost]
        public IHttpActionResult Add(ViewModels.ClienteViewModel model)
        {
            using (Models.MercadoEntities1 db = new Models.MercadoEntities1())
            {
                var oCliente = new Models.Clientes();
                oCliente.Nombre = model.Nombre;
                oCliente.Apellido = model.Apellido;
                oCliente.Telefono = model.Telefono;
                db.Clientes.Add(oCliente);
                db.SaveChanges();
            }
            return Ok("Registro agregado correctamente.");
        }

        [HttpPut]
        public IHttpActionResult Put(ViewModels.ClienteViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest("No es un modelo válido");

            using (Models.MercadoEntities1 db = new Models.MercadoEntities1())
            {
                var oCliente = db.Clientes.Where(c => c.Id == model.Id)
                    .FirstOrDefault<Models.Clientes>();
                if (oCliente != null)
                {
                    oCliente.Nombre = model.Nombre;
                    oCliente.Apellido = model.Apellido;
                    oCliente.Telefono = model.Telefono;
                    db.SaveChanges();
                }
                else
                    return NotFound();
            }
            return Ok("Registro actualizado.");
        }


        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("No es un Id de cliente válido");
            using (Models.MercadoEntities1 db = new Models.MercadoEntities1())
            {
                var cliente = db.Clientes.Where(c => c.Id == id)
                    .FirstOrDefault();
                db.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
            return Ok();
        }

    }
}
