using System.Linq.Dynamic.Core;
using System.Linq.Expressions;

namespace InsuranceApi.Common;

public static class QueryableExtensions
{
    public static IQueryable<TSource> WhereIf<TSource>(
        this IQueryable<TSource> source,
        bool condition,
        string clause,
        object?[] parameters
    )
    {
        return condition ? source.Where(clause, parameters) : source;
    }

    public static IQueryable<TSource> WhereIf<TSource>(
        this IQueryable<TSource> source,
        bool condition,
        Expression<Func<TSource, bool>> expression
    )
    {
        return condition ? source.Where(expression) : source;
    }
}