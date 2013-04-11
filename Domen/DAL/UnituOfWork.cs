using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domen.Entities;

namespace Domen.DAL
{
    public class UnituOfWork : IDisposable
    {
        private GenericRepository<Customer> customerRepository;
        private GenericRepository<Order> orderRepository;
        private GenericRepository<OrderLine> orderLineRepository;

        EFDbContext context = new EFDbContext();

        #region RepositoryClasses
        public GenericRepository<Customer> CustomerRepository
        {
            get
            {
                if (customerRepository == null)
                {
                    customerRepository = new GenericRepository<Customer>(context);
                }
                return customerRepository;
            }
        }

        public GenericRepository<Order> OrderRepository
        {
            get
            {
                if (orderRepository == null)
                {
                    orderRepository = new GenericRepository<Order>(context);
                }
                return orderRepository;
            }
        }

        public GenericRepository<OrderLine> OrderLineRepositoryRepository
        {
            get
            {
                if (orderLineRepository == null)
                {
                    orderLineRepository = new GenericRepository<OrderLine>(context);
                }
                return orderLineRepository;
            }
        }

        #endregion

        public void Save()
        {
            if (context != null) context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
