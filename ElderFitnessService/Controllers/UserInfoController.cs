using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using ElderFitnessService.DataObjects;
using ElderFitnessService.Models;

namespace FitnessRunningService.Controllers
{
    public class UserInfoController : TableController<UserInfo>
    {

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            ElderFitnessContext context = new ElderFitnessContext();
            DomainManager = new EntityDomainManager<UserInfo>(context, Request);
        }

        // GET tables/TodoItem
        public IQueryable<UserInfo> GetAllUserInfoes()
        {
            return Query();
        }

        // GET tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<UserInfo> GetUserInfo(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<UserInfo> PatchUserInfo(string id, Delta<UserInfo> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TodoItem
        public async Task<IHttpActionResult> PostUserInfo(UserInfo item)
        {
            UserInfo current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteUserInfo(string id)
        {
            return DeleteAsync(id);
        }
    }
}
