using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWorkDal : IUnitOfWorkDal
    {
        private readonly Context _context;
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
