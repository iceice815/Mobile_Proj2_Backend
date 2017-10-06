using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using ElderFitnessService.DataObjects;
using ElderFitnessService.Models;

namespace ElderFitnessService.Controllers
{
    public class RecordTrackController : TableController<RecordTrack>
    {

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            ElderFitnessContext context = new ElderFitnessContext();
            DomainManager = new EntityDomainManager<RecordTrack>(context, Request);
        }

        // GET tables/TodoItem
        public IQueryable<RecordTrack> GetAllRecordTracks()
        {
            return Query();
        }

        // GET tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<RecordTrack> GetRecordTrack(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<RecordTrack> PatchRecordTrack(string id, Delta<RecordTrack> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TodoItem
        public async Task<IHttpActionResult> PostRecordTrack(RecordTrack item)
        {
            RecordTrack current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteRecordTrack(string id)
        {
            return DeleteAsync(id);
        }
    }
}
