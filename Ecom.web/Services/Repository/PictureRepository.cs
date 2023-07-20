using System;
using Ecom.web.Data;
using Ecom.web.models;
using Ecom.web.Services.Infrastructure;

namespace Ecom.web.Services.Repository
{
	public class PictureRepository : IPicture
    {
        private ApplicationDbContext _context;

        public PictureRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var picture = _context.Pictures.FirstOrDefault(p=>p.Id == id);
            if(picture != null)
            {
                _context.Pictures.Remove(picture);
            }
        }

        public IEnumerable<Picture> GetPictures()
        {
            return _context.Pictures;
        }

        public Picture GetPicture(int id)
        {
            var picture = _context.Pictures.FirstOrDefault(p => p.Id == id);
            if (picture != null)
            {
                return picture;
            }
            return null;
        }

        public void Insert(Picture picture)
        {
            _context.Pictures.Add(picture);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Picture picture)
        {
            _context.Pictures.Update(picture);
        }
    }
}

