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
    public class BranchManager : IBranchService
    {
        IBranchDal _branchDal;

        public BranchManager(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }

        public List<Branch> GetList()
        {
            return _branchDal.GetListAll();
        }

        public void TAdd(Branch t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Branch t)
        {
            throw new NotImplementedException();
        }

        public Branch TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Branch t)
        {
            throw new NotImplementedException();
        }
    }
}
