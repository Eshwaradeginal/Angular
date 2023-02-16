using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.UI.WebControls;
using TPlaces.Models;


namespace WebApiComponents.Controllers
{
    //[EnableCors("*", "*", "*", "*")]
    public class PlacesController : ApiController
    {
        private readonly PlacesEntities dbContext = new PlacesEntities();

        [ResponseType(typeof(List<Place>))]
        public async Task<IHttpActionResult> GetAllPlaces()
        {
            var data = dbContext.TPlaces.Select((p) => new Place
            {
                PlaceId = p.PlaceId,
                Description = p.Description,
                Name = p.Name,
                
                Significance = p.Significance,
                State = p.State
            }).ToList();
            return await Task.Run<IHttpActionResult>(() => Ok(data));
        }

        [ResponseType(typeof(Place))]
        public async Task<IHttpActionResult> GetPlace(int id)
        {
            var data = dbContext.TPlaces.FirstOrDefault((pl) => pl.PlaceId == id);
            var place = new Place
            {
                PlaceId = data.PlaceId,
                Description = data.Description,
                Name = data.Name,
               
                Significance = data.Significance,
                State = data.State
            };

            return await Task.Run<IHttpActionResult>(() => Ok(place));
        }

        [ResponseType(typeof(List<ImageField>))]
        [Route("api/Places/Images/{id}")]
        public async Task<IHttpActionResult> GetImages(int id)
        {
            var data = dbContext.TImageFiles.Where((f) => f.PlaceId == id).Select(f => new ImgFile
            {
                EntryId = f.EntryId,
                Image = f.image,
                PlaceId = (int)f.PlaceId
            }).ToList();
            return await Task.Run<IHttpActionResult>(() => Ok(data));
        }

        [ResponseType(typeof(Place))]
        [HttpPost]
        public async Task<IHttpActionResult> AddPlace(Place place)
        {
            var tPlace = new TPlace
            {
                Description = place.Description,
                Name = place.Name,
                
                Significance = place.Significance,
                State = place.State
            };
            dbContext.TPlaces.Add(tPlace);
            dbContext.SaveChanges();
            place.PlaceId = tPlace.PlaceId;
            return await Task.Run<IHttpActionResult>(() => Ok(place));
        }

        [ResponseType(typeof(TPlace))]
        [HttpPost]
        [Route("api/Places/Tourist")]
        public async Task<IHttpActionResult> AddNewPlace(TPlace place)
        {
            dbContext.TPlaces.Add(place);
            var rows = await dbContext.SaveChangesAsync();
            return await Task.Run<IHttpActionResult>(() => Ok(rows));
        }

        [HttpPost]
        [Route("api/Images/{id}")]
        public async Task<IHttpActionResult> AddImages(int id, ImgFile file)
        {
            var imgFile = new TImageFile
            {
                image = file.Image,
                PlaceId = file.PlaceId
            };
            dbContext.TImageFiles.Add(imgFile);
            dbContext.SaveChanges();
            return await Task.Run<IHttpActionResult>(() => Ok());
        }



    }
}
