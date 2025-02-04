using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class BizFileAPIMallController : ApiController
    {
        public List<BizFileAPIMallModel> Post(BizFileAPIMallModel bizfileAPIMall)
        {
            BizFileAPIMallModel bizModel = new BizFileAPIMallModel();
            Entity ent = new Entity();
            Shareholders sh = new Shareholders();
            Grouping gp = new Grouping();

            ent.Uen = "AB1234567";
            ent.Name = "ABC";
            ent.CompanyType = "BCD";

            gp.ShareGroup = "A";

            sh.Grouping = new Grouping[]
            {
                gp
            };

            ent.Shareholders = sh;

            bizModel.Entities = new Entity[]
            {
                ent
            };

            return new List<BizFileAPIMallModel> {
                bizModel
            };
        }
    }
}
