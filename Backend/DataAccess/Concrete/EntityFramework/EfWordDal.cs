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
    public class EfWordDal : IWordDal
    {
        public Word Get(Expression<Func<Word, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Word> GetAll(Expression<Func<Word, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public void Add(Word entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Word entity)
        {
            throw new NotImplementedException();
        }
        public void Update(Word entity)
        {
            throw new NotImplementedException();
        }
    }
}
