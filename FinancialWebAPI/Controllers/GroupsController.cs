using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FinancialWebAPI.Controllers
{
    /// <summary>
    /// Groups Controller
    /// </summary>
    [RoutePrefix("api/Groups")]
    public class GroupsController : BaseController
    {
        /// <summary>
        /// Add Group
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        [HttpPost, Route("AddGroup")]
        public IHttpActionResult AddGroup(string Name)
        {
            return Ok(db.AddGroup(Name));
        }
        /// <summary>
        /// Get All Groups 
        /// </summary>
        /// <returns></returns>
        [Route("GetGroups")]
        public async Task<IHttpActionResult> GetGroups()
        {
            var data = await db.GetGroups();
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }
        /// <summary>
        /// Get Group by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("GetGroupDetails")]
        public async Task<IHttpActionResult> GetGroupDetails(int Id)
        {
            var data = await db.GetGroupDetails(Id);
            return Json(data, new JsonSerializerSettings { Formatting = Formatting.Indented });
        }
        /// <summary>
        /// Edit Group
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Name"></param>
        /// <param name="Balance"></param>
        /// <param name="StartAmount"></param>
        /// <returns></returns>
        [HttpPut, Route("EditGroup")]
        public IHttpActionResult EditGroup(int Id, string Name, decimal Balance, decimal StartAmount)
        {
            return Ok(db.EditGroup(Id, Name, Balance, StartAmount));
        }
        /*/// <summary>
        /// Delete Group
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete, Route("DeleteGroup")]
        public IHttpActionResult DeleteGroup(int Id)
        {
            return Ok(db.DeleteGroup(Id));
        }*/

    }
}
