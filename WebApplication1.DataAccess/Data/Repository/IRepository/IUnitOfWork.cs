using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork: IDisposable
    {
        ICategoryRepository Category { get; }
        void Save();
    }
}
