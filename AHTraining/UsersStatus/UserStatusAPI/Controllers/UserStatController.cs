using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using UserStatus.Model;
using UserStatus.Data;

namespace UserStatusAPI.Controllers
{
    public class UserStatController : ApiController
    {
        private UnitOfWork _UoW = null;

        public UserStatController ()
        {
            _UoW = new UnitOfWork();
        }

        public JsonResult<IEnumerable<User>> Get()
        {
            return Json(_UoW.Users.GetAll());
        }

        public JsonResult<User> Post(User user)
        {
            _UoW.Users.Create(user);
            _UoW.Commit();
            return Json(user);
        }

        public JsonResult<User> Delete(User user)
        {
            _UoW.Users.Delete(user);
            _UoW.Commit();
            return Json(user);
        }

        public JsonResult<User> Put([FromBody] User user)
        {
            _UoW.Users.Update(user);
            _UoW.Commit();
            return Json(user);
        }

    }
}
