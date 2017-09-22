using CartWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CartWeb.Controllers
{

    public class HomeController : ApiController
    {
        ModelGadgets gadgets = new ModelGadgets();

        List<ModelGadgets> gadgetList = new List<ModelGadgets>()
        {
            new ModelGadgets {IdGadgets = 1, Name = "Iphone", Type= "phone", Descriptions = "bla bla", Prise = 1000  },
            new ModelGadgets {IdGadgets = 2, Name = "Ipod", Type= "player", Descriptions = "bla bla", Prise = 1000  }
        };


        [HttpGet]
        [Route("api/cart/all")]
        public IEnumerable<ModelGadgets> GetCartList()
        {
            return gadgetList;
        }

        [HttpGet]
        [Route("api/cart/{id}")]
        public IEnumerable<ModelGadgets> GetCart(int id)
        {
            yield return gadgetList.Find(x => x.IdGadgets == id);
        }

        [HttpPost]
        [Route("api/cart/add" )]
        public IEnumerable<ModelGadgets> AddCart([FromBody]ModelGadgets gadgetsPost )
        {
             gadgetList.Add(new ModelGadgets { IdGadgets = gadgetsPost.IdGadgets, Name = gadgetsPost.Name, Type = gadgetsPost.Type,
                                               Descriptions = gadgetsPost.Descriptions, Prise = gadgetsPost.Prise });

             return gadgetList;
        }

        [HttpDelete]
        [Route("api/cart/{id}")]
        public IEnumerable<ModelGadgets> DeleteCart(int id)
        {
            var delId = gadgetList.Find(x => x.IdGadgets == id);

            gadgetList.Remove(delId);

            return gadgetList;
        }
    }
}
