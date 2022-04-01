using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAdminDal : IAdminDal
    {
        public void Add(Admin entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Admin Get(Expression<Func<Admin, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAll(Expression<Func<Admin, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}
