﻿using System.Net.Http;
using System.Web.Http;

namespace OWinHost.AspNet48.WebApi.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: api/Default
        public IHttpActionResult Get()
        {
            var key    = typeof(Member).FullName;
            var member = this.Request.GetOwinContext().Get<Member>(key);
            return this.Ok(member);
        }
    }
}