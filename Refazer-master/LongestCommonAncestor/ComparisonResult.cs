﻿namespace LongestCommonAncestor
{
    /// <summary>
    /// Comparison result
    /// </summary>
    /// <typeparam name="T">Object to be compared</typeparam>
    public class ComparisonResult<T>
    {
        /// <summary>
        /// Modification type
        /// </summary>
        /// <returns>Modification type</returns>
        public EditionType EditionType { get; set; }

        /// <summary>
        /// Data compared
        /// </summary>
        /// <returns>Object compared</returns>
        public T DataCompared { get; set; }

    }
}
