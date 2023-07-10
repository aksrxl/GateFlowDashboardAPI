namespace GateFlowDashboardAPI.EFCore;

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

public static class DynamicFilterGenerator
{
    public static Expression<Func<T, bool>> GenerateFilterExpression<T>(Dictionary<string, List<string>> filterParams)
    {
        var parameter = Expression.Parameter(typeof(T), "x");
        Expression filterExpression = null;

        if (filterParams != null && filterParams.Count > 0)
        {
            foreach (var filterParam in filterParams)
            {
                string columnName = filterParam.Key;
                List<string> filterValues = filterParam.Value;

                var property = Expression.Property(parameter, columnName);

                if (typeof(DateTime).IsAssignableFrom(property.Type) && filterValues.Count == 2)
                {
                    if (DateTime.TryParse(filterValues[0], out var startDate) && DateTime.TryParse(filterValues[1], out var endDate))
                    {
                        var startExpression = Expression.GreaterThanOrEqual(property, Expression.Constant(startDate.Date));
                        var endExpression = Expression.LessThanOrEqual(property, Expression.Constant(endDate.Date.AddDays(1).AddSeconds(-1)));

                        var dateExpression = Expression.AndAlso(startExpression, endExpression);

                        filterExpression = filterExpression == null ? dateExpression : Expression.AndAlso(filterExpression, dateExpression);
                    }
                }
                else
                {
                    Expression columnExpression = null;

                    foreach (var filterValue in filterValues)
                    {
                        var equals = Expression.Equal(property, Expression.Constant(filterValue));

                        if (columnExpression == null)
                        {
                            columnExpression = equals;
                        }
                        else
                        {
                            columnExpression = Expression.OrElse(columnExpression, equals);
                        }
                    }

                    filterExpression = filterExpression == null ? columnExpression : Expression.AndAlso(filterExpression, columnExpression);
                }
            }
        }
        else
        {
            // Default to a true expression if filterParams is null or empty
            filterExpression = Expression.Constant(true);
        }

        var lambda = Expression.Lambda<Func<T, bool>>(filterExpression, parameter);

        return lambda;
    }
}






