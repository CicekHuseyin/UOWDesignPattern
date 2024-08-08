using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public CustomerManager(ICustomerDal customerDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _customerDal = customerDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public void TDelete(Customer t)
        {
            _customerDal.Delete(t);
            _unitOfWorkDal.Save();
        }

        public Customer TGetByID(int id)
        {
            return _customerDal.GetByID(id);
        }

        public List<Customer> TGetList()
        {
            return _customerDal.GetList();
        }

        public void TInsert(Customer t)
        {
            _customerDal.Insert(t);
            _unitOfWorkDal.Save();
        }

        public void TMultiUpdate(List<Customer> t)
        {
            _customerDal.MultiUpdate(t);
            _unitOfWorkDal.Save();
        }

        public void TUpdate(Customer t)
        {
            _customerDal.Update(t);
            _unitOfWorkDal.Save();
        }
    }
}
