using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Api_Assignment.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;
using System.Web.Http.Routing; 
//using System.Web.Http.HttpPost;

namespace Web_Api_Assignment.Controllers
{
    [System.Web.Http.RoutePrefix("api/Country")]
    public class CountryController : ApiController
    {
        static List<Country> countrylist = new List<Country>()
        {
            new Country{ID=1,CountryName="India",Capital ="Delhi"},
            new Country{ID=2,CountryName="Canada",Capital="ottava"},
            new Country{ID=3,CountryName="Australia", Capital="Melbourne"},
        };

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("General")]
        public IEnumerable<Country> Get()
        {
            return countrylist;
        }
        //Get using HttpResponseMessage object
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("CountryHttp")]
        public HttpResponseMessage GetCountryList()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, countrylist);
            
            response.Headers.CacheControl = new CacheControlHeaderValue()
            {
                MaxAge = TimeSpan.FromMinutes(10)
            };
            return response;
        }

        //implement IHttpActionResult to get users by id
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("ById")]
        public IHttpActionResult GetByID(int cid)
        {
            var ctr = countrylist.Find(x => x.ID == cid);
            if (ctr == null)
            {
                return NotFound();
            }
            return Ok(ctr);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("GetName")]
        public IHttpActionResult GetUserByname(int cid)
        {
            string cname = countrylist.Where(a => a.ID == cid).SingleOrDefault()?.CountryName;
            if (cname == null)
            {
                return NotFound();
            }
            return Ok(cname);
        }

        //Post 1 
        public Country Post([FromBody] Country c)
        {
            countrylist.Add(c);
            return c;
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("AllPost")]



        public List<Country> PostAll([FromBody] Country cntr)
        {
            countrylist.Add(cntr);
            return countrylist;
        }

        [System.Web.Http.HttpPost]

        public void CountryPost([FromUri] int ID, string CountryName, string Capital)
        {
            Country c = new Country();
            c.ID = ID;
            c.CountryName = CountryName;
            c.Capital = Capital;
            countrylist.Add(c);
        }

        //put

        public void Put(int id, [FromBody] Country c)
        {
       countrylist[id - 1] = c;
        }

        //delete
        [System.Web.Http.HttpDelete]
        public void Delete(int id)
        {
            countrylist.RemoveAt(id - 1);
        }
        
        //public class CountryController : Controller
        //{
        //    // GET: Country
        //    public ActionResult Index()
        //    {
        //        return View();
        //    }
        //}
    }
}
