using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiMercado.Controllers
{
    public class ProductosController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            List<ViewModels.ProductosViewModel> list =
             new List<ViewModels.ProductosViewModel>();

            using (Models.MercadoEntities1 db = new Models.MercadoEntities1())
            {
                list = (from c in db.Productos
                        select new ViewModels.ProductosViewModel
                        {
                            Id = c.Id,
                            Nombre = c.Nombre,
                            Precio = c.Precio,
                            Cantidad = c.Cantidad

                        }).ToList();
            }
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            ViewModels.ProductosViewModel producto = null;
            using (Models.MercadoEntities1 db =
                new Models.MercadoEntities1())
            {
                producto = db.Productos.Where(c => c.Id == id)
                    .Select(c => new ViewModels.ProductosViewModel()
                    {
                        Id = c.Id,
                        Nombre = c.Nombre,
                        Precio = c.Precio,
                        Cantidad = c.Cantidad

                    }).FirstOrDefault<ViewModels.ProductosViewModel>();
            }
            if (producto == null)
                return NotFound();

            return Ok(producto);
        }

        [HttpPost]
        public IHttpActionResult Add(ViewModels.ProductosViewModel model)
        {
            using (Models.MercadoEntities1 db = new Models.MercadoEntities1())
            {
                var oProducto = new Models.Productos();
                oProducto.Nombre = model.Nombre;
                oProducto.Precio = model.Precio;
                oProducto.Cantidad = model.Cantidad;
                db.Productos.Add(oProducto);
                db.SaveChanges();
            }
            return Ok("Producto agregado correctamente.");
        }

        [HttpPut]
        public IHttpActionResult Put(ViewModels.ProductosViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest("No es un modelo válido");

            using (Models.MercadoEntities1 db = new Models.MercadoEntities1())
            {
                var oProductos = db.Productos.Where(c => c.Id == model.Id)
                    .FirstOrDefault<Models.Productos>();
                if (oProductos != null)
                {
                    oProductos.Nombre = model.Nombre;
                    oProductos.Precio = model.Precio;
                    oProductos.Cantidad = model.Cantidad;
                    db.SaveChanges();
                }
                else
                    return NotFound();
            }
            return Ok("Producto actualizado.");
        }


        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("No es un Id de producto válido.");
            using (Models.MercadoEntities1 db = new Models.MercadoEntities1())
            {
                var producto = db.Productos.Where(c => c.Id == id)
                    .FirstOrDefault();
                db.Entry(producto).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
            return Ok();
        }
    }
}
