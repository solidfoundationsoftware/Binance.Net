using System;
using System.Collections.Generic;

namespace Binance.Net.Objects
{
    /// <summary>
    /// Query results
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinanceDetailRecords<T>
    {
        /// <summary>
        /// The list records
        /// </summary>
        public Dictionary<string, T> AssetDetail { get; set; } = new Dictionary<string, T>();// = Array.Empty<T>();
        /// <summary>
        /// Response status.
        /// </summary>
        public bool Success { get; set; }
    }
}
