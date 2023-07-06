using Book.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Book.DAL.Repository
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
    