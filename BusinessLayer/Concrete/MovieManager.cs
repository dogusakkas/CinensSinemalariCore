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

        public List<Movie> GetHorizontalMovie()
        {
            return _movieDal.GetListAll().Take(5).ToList();
        }

        public List<Movie> GetList()
        {
            return _movieDal.GetListAll();
        }

        public List<Movie> GetMovieByID(int id)
        {
            return _movieDal.GetListAll(x => x.MovieID == id);
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
