using System;
using Ecom.web.models;

namespace Ecom.web.Services.Infrastructure
{
	public interface IPicture
	{
		IEnumerable<Picture> GetPictures();

        Picture GetPicture(int id);

		void Insert(Picture picture);

		void Update(Picture picture);

		void Delete(int id);

		void Save();
	}
}

