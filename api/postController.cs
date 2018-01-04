using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FunTour.Models;

namespace FunTour.api
{
    public class postController : ApiController
    {
        private ApplicationDbContext _context;

        public postController()
        {
            _context = new ApplicationDbContext();
        }
        public IEnumerable<Posts> GetPost()
        {
            return _context.post.ToList();
        }

      
        [HttpDelete]
        public void Delpost(int id)
        {
          
            var post = _context.post.SingleOrDefault(c => c.Id == id);
            _context.post.Remove(post);
            _context.SaveChanges();

        }
    }
}
