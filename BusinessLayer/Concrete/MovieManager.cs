using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MovieManager : IMovieService
    {
        IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public List<Movie> GetList()
        {
            return _movieDal.GetListAll();
        }

        public void TAdd(Movie t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Movie t)
        {
            throw new NotImplementedException();
        }

        public Movie TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Movie t)
        {
            throw new NotImplementedException();
        }
    }
}
