using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specification
{
    public interface ISpecification<T> where T : BaseEntity
    {
         Expression<Func<T, bool>> Criteria {get;}

         List<Expression<Func<T, object>>> Includes {get;}

        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }

        int Skip {get;}
        int Take {get;}
        bool IsPaginationEnabled { get; }
    }
}