using System;
using System.Linq.Expressions;
using System.Reflection;

namespace TeamsPortfolio
{
    /// <summary>
    /// a helper for expressions
    /// </summary>
    public static class ExpressionHelpers
    {
        /// <summary>
        /// compiles an expression and gets the functions return value
        /// </summary>
        /// <typeparam name="T">the type of return value</typeparam>
        /// <param name="lambda">the expression to compile</param>
        /// <returns></returns>
        public static T GetPropertyValue<T>(this Expression<Func<T>> lambda)
        {
            return lambda.Compile().Invoke();
        }

        /// <summary>
        /// sets the underlying properties value to the given value, 
        /// from an expression that contains the property
        /// </summary>
        /// <typeparam name="T">the type of value to set</typeparam>
        /// <param name="lambda">the expression</param>
        /// <param name="value">the value to set the property to</param>
        /// <returns></returns>
        public static void SetPropertyValue<T>(this Expression<Func<T>> lambda, T value)
        {
            // converts a lambda () => some.Property, to some.Property
            var expression = (lambda as LambdaExpression).Body as MemberExpression;

            // get the property information so we can set it
            var propertyInfo = (PropertyInfo)expression.Member;
            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

            // set the property value
            propertyInfo.SetValue(target, value);
        }
        
    }
}
