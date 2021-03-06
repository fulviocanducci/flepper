﻿using System;

namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Comparison Operator Interface
    /// </summary>
    public interface IComparisonOperators : IQueryCommand, ISortCommand
    {
        /// <summary>
        /// Equal Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators EqualTo<T>(T value);

        /// <summary>
        /// Equal Null Comparison Operator Contract
        /// </summary>
        /// <returns></returns>
        IComparisonOperators EqualNull();

        /// <summary>
        /// Greater Than Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators GreaterThan<T>(T value);

        /// <summary>
        /// Less Than Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators LessThan<T>(T value);

        /// <summary>
        /// Greater Than Or Equal Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators GreaterThanOrEqualTo<T>(T value);

        /// <summary>
        /// Less Than Or Equal Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators LessThanOrEqualTo<T>(T value);

        /// <summary>
        /// Not equal Comparison Operator Contract
        /// </summary>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators NotEqualTo<T>(T value);

        /// <summary>
        /// Contains
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators Contains<T>(T value);

        /// <summary>
        /// StartsWith
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators StartsWith<T>(T value);

        /// <summary>
        /// EndsWith
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">Value used to compare</param>
        /// <returns></returns>
        IComparisonOperators EndsWith<T>(T value);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TFrom"></typeparam>
        /// <typeparam name="TTo"></typeparam>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        IComparisonOperators Between<TFrom, TTo>(TFrom from, TTo to);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        IComparisonOperators In(params object[] values);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        IComparisonOperators NotIn(params object[] values);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        IComparisonOperators In(Func<IQueryCommand, IQueryCommand> query);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        IComparisonOperators NotIn(Func<IQueryCommand, IQueryCommand> query);
    }
}
