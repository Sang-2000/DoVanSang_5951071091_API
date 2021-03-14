using DoVanSang_5951071091_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoVanSang_5951071091_API.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var studentInlist = new List<StudentInfo>();
            for (int i = 0; i < 10; i++)
            {
                var StudentInfo = new StudentInfo
                {
                    NameStudent = $"Do Van Sang + {i}",
                    IdStudent = i ,
                    DateStudent = DateTime.Now.ToUniversalTime()
                };
                studentInlist.Add(StudentInfo);
            }

            return studentInlist;

        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                NameStudent = $"Do Van Sang {id}",
                IdStudent = id,
                DateStudent = DateTime.Now.ToUniversalTime()
            }; ;
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
