using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WrapperExtensions;

namespace angularmvc.Controllers
{
    public class TasksController : ApiController
    {
        private readonly Repository _repository;

        public TasksController()
        {
            this._repository = new Repository(new ModelStateWrapper(this.ModelState));
        }

        // GET: api/Tasks
        public IEnumerable<List> Get()
        {
            var tl = this._repository.Entity<List>().OrderBy(o => o.Id).ToList();

            return tl;
        }

        // GET: api/Tasks/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post(Task task)
        {
            this._repository.Insert(task);
            this._repository.Save();
        }

        [HttpPut]
        public void Put(int id, [FromBody]Task task)
        {
            this._repository.Update(task);
            this._repository.Save();
        }

        // DELETE: api/Tasks/5
        public void Delete(int id)
        {
            this._repository.Delete<Task>(id);
            this._repository.Save();
        }

        // POST: api/Tasks/List
        [HttpPost]
        [Route("api/tasks/list")]
        public void List(List list)
        {
            this._repository.Insert(list);
            this._repository.Save();
        }


        // PUT: api/Tasks/List/5
        [HttpPut]
        [Route("api/tasks/list/{id}")]
        public void List(int id, [FromBody]List list)
        {
            this._repository.Update(list);
            this._repository.Save();
        }

        [HttpDelete]
        [Route("api/tasks/list/{id}")]
        public void List(int id)
        {
            this._repository.Delete<List>(id);
            this._repository.Save();
        }
    }
}
