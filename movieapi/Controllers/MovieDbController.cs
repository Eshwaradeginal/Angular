using MovieService.Models;
using MovieService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Director = MovieService.ViewModel.Director;

namespace MovieService.Controllers
{
  public class MovieDbController : ApiController
  {
    private readonly MovieEntities movieContext = new MovieEntities();

    [HttpGet]
    [ResponseType(typeof(List<Actor>))]
    [Route("api/Actor")]
    public async Task<IHttpActionResult> getAllActor()
    {

      //var data = movieContext.MVCACTORs.ToList();
      var data = movieContext.MVCACTORs.Select((m) => new Actor
      {
        ACTID = m.ACTID,
        ACTNAME = m.ACTNAME

      }).ToList();
      return await Task.Run<IHttpActionResult>(() => Ok(data));
    }




    [HttpGet]
    [ResponseType(typeof(List<Director>))]
    [Route("api/Director")]
    public async Task<IHttpActionResult> GetAllDirector()
    {
      var data = movieContext.MVCDIRECTORs.Select((d)=>new Director
      {
        DIRID=d.DIRID,DIRNAME=d.DIRNAME
      }).ToList();

      return await Task.Run<IHttpActionResult>(() => Ok(data));
    }


    [HttpGet]
    [ResponseType(typeof(List<Movies>))]
    [Route("api/Movies")]
    public async Task<IHttpActionResult> getAllMovies()
    {
      var data = movieContext.MVCMOVIES.Select((mv)=>new Movies {
        DIRID=mv.DIRID,MOVID=mv.MOVID,MOVTITLE=mv.MOVTITLE,MOVLANG=mv.MOVLANG,
        MOVYEAR=mv.MOVYEAR,Image=mv.Image
      }).ToList();
      return await Task.Run<IHttpActionResult>(() => Ok(data));
    }




    [HttpGet]
    [ResponseType(typeof(List<Moviecast>))]
    [Route("api/moviecast")]
    public async Task<IHttpActionResult> getAllMovieCast()
    {
      var data = movieContext.MVCMOVIECASTs.Select((mc) => new Moviecast
      {
        ACTID = mc.ACTID,
        MOVID = mc.MOVID,
        ROLE = mc.ROLE
      }).ToList();
      return await Task.Run<IHttpActionResult>(() => Ok(data));
    }


    //====================================================================================

    //add actors
    [ResponseType(typeof(Actor))]

    [HttpPost]
    [Route("api/Actor")]
    public async Task<IHttpActionResult> AddActor(Actor act)
    {

      var data = movieContext.MVCACTORs.Add(new Actor
      {
        ACTID = act.ACTID,
        ACTNAME = act.ACTNAME
      });
      movieContext.SaveChanges();
      return await Task.Run<IHttpActionResult>(() => Ok(data));
    }




    //director

    //addmovies

    //addmoviecast

  }
}
