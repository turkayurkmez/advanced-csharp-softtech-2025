using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTreeQueryBuilder
{
    public static class SqlBuilder
    {
        public static string BuildWhere<T>(Expression<Func<T,bool>> predicate)
        {
            return processExpression(predicate.Body);
        }

        private static string processExpression(Expression body)
        {
            switch (body.NodeType)
            {
              
                case ExpressionType.Equal:
                    var equality = (BinaryExpression)body;
                    return $"{getMemberName(equality.Left)} = {getValue(equality.Right)}";
              
                case ExpressionType.GreaterThan:
                    var greaterThan = (BinaryExpression)body;
                    return $"{getMemberName(greaterThan.Left)} > {getValue(greaterThan.Right)}";
                case ExpressionType.GreaterThanOrEqual:
                    var greaterThanOrEqual = (BinaryExpression)body;
                    return $"{getMemberName(greaterThanOrEqual.Left)} >= {getValue(greaterThanOrEqual.Right)}";
                  

                case ExpressionType.AndAlso:
                     var and = (BinaryExpression)body;
                    return $"{processExpression(and.Left)} AND {processExpression(and.Right)}";
                   
                
                case ExpressionType.OrElse:
                    var orElse = (BinaryExpression)body;
                    return $"{processExpression(orElse.Left)} OR {processExpression(orElse.Right)}";
                                 
                default:
                    throw new NotSupportedException($"{body.NodeType} işlemi desteklenmiyor");
            }
        }

   

        private static string getMemberName(Expression expression)
        {
            if (expression is MemberExpression member)
            {
                return member.Member.Name;
            }

            throw new ArgumentException("Expression, member olmalı");
        }

        private static object getValue(Expression expression)
        {
            if (expression is ConstantExpression constant)
            {
                return constant.Value is string ? $"\"{constant.Value}\"": constant.Value;
            }

            //Eğer değer bir değişkendeyse:
            var lambda = Expression.Lambda(expression);
            var value = lambda.Compile().DynamicInvoke();
            return value is string ? $"\"{value}\"" : value;
        }
    }
}
