using System.Collections.Generic;
using System.Web.Mvc;

namespace Dev.BigApp.Api.Controllers
{
    public class CityController : Controller
    {
        /// <summary>
        /// Get city list metod.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get city by city id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }
    }
}