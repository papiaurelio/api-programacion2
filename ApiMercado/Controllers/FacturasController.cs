using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiMercado.Controllers
{
    public class FacturasController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            List<ViewModels.FacturasViewModel> list =
             new List<ViewModels.FacturasViewModel>();

            using (Models.MercadoEntities1 db = new Models.MercadoEntities1())
            {
                list = (from c in db.Facturas
                        select new ViewModels.FacturasViewModel
                        {
                            Id = c.Id,
                            IdCliente = c.IdCliente,
                            NombreCliente = c.NombreCliente,
                            Subtotal = c.Subtotal,
                            IVA = c.IVA,
                            Total = c.Total,
                            FechaFactura = c.FechaFactura

                        }).ToList();
            }
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            ViewModels.FacturasViewModel factura = null;
            using (Models.MercadoEntities1 db =
                new Models.MercadoEntities1())
            {
                factura = db.Facturas.Where(c => c.Id == id)
                    .Select(c => new ViewModels.FacturasViewModel()
                    {
                        Id = c.Id,
                        IdCliente = c.IdCliente,
                        NombreCliente = c.NombreCliente,
                        Subtotal = c.Subtotal,
                        IVA = c.IVA,
                        Total = c.Total,
                        FechaFactura = c.FechaFactura

                    }).FirstOrDefault<ViewModels.FacturasViewModel>();
            }
            if (factura == null)
                return NotFound();

            return Ok(factura);
        }

        [HttpPost]
        public IHttpActionResult Add(ViewModels.FacturasViewModel model)
        {
            using (Models.MercadoEntities1 db = new Models.MercadoEntities1())
            {
                var oFactura = new Models.Facturas();
                oFactura.IdCliente = model.IdCliente;
                oFactura.NombreCliente = model.NombreCliente;
                oFactura.Subtotal = model.Subtotal;
                oFactura.IVA = model.IVA;
                oFactura.Total = model.Total;
                oFactura.FechaFactura = model.FechaFactura;

                db.Facturas.Add(oFactura);
                db.SaveChanges();
            }
            return Ok("Factura agregada correctamente.");
        }



        ///**** Métodos que por el momento no se van a ultilizar¨***///
        ///




        //[HttpPut]
        //public IHttpActionResult Put(ViewModels.FacturasViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest("No es un modelo válido");

        //    using (Models.MercadoEntities1 db = new Models.MercadoEntities1())
        //    {
        //        var oFactura = db.Facturas.Where(c => c.Id == model.Id)
        //            .FirstOrDefault<Models.Facturas>();
        //        if (oFactura != null)
        //        {
        //            oFactura.IdCliente = model.IdCliente;
        //            oFactura.NombreCliente = model.NombreCliente;
        //            oFactura.Subtotal = model.Subtotal;
        //            oFactura.IVA = model.IVA;
        //            oFactura.Total = model.Total;
        //            oFactura.FechaFactura = model.FechaFactura;
        //            db.SaveChanges();
        //        }
        //        else
        //            return NotFound();
        //    }
        //    return Ok("Factura actualizada.");
        //}


        //[HttpDelete]
        //public IHttpActionResult Delete(int id)
        //{
        //    if (id <= 0)
        //        return BadRequest("No es un Id de factura válido.");

        //    using (Models.MercadoEntities1 db = new Models.MercadoEntities1())
        //    {
        //        var factura = db.Facturas.Where(c => c.Id == id)
        //            .FirstOrDefault();
        //        db.Entry(factura).State = System.Data.Entity.EntityState.Deleted;
        //        db.SaveChanges();
        //    }
        //    return Ok("Factura eliminada.");
        //}
    }
}
