using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace WebApplication1.DataAccess.Data.Repository.IRepository
{
    //T is will be used for Category, so it is assign to class
    public interface IRepository<T> where T:class
    {
        //Get category base on id, return type here will be generic T or class
         T Get(int id);

        //With GetAll we will get a list of Categor, we need to filter data sometimes , order by, include properties
        IEnumerable<T> GetAll(
            // link opperation for filtering 
            Expression<Func<T, bool>> filter = null,
            // Order by class
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            //include properties, also assign to null if it is not needed
            string includeProperties = null
            );

        //Return only one object 
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        //Function to add any entity 
        void Add(T entity);

        //Remove on Category id
        void Remove(int id);

        //Remove the complete entity from database
        void Remove(T entity);

    }
}
