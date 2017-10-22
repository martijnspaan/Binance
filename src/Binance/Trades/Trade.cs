﻿namespace Binance.Trades
{
    /// <summary>
    /// A abstract trade class.
    /// </summary>
    public abstract class Trade : IChronological
    {
        #region Public Properties

        /// <summary>
        /// Get the symbol.
        /// </summary>
        public string Symbol { get; private set; }

        /// <summary>
        /// Get the trade ID.
        /// </summary>
        public long Id { get; private set; }

        /// <summary>
        /// Get the price.
        /// </summary>
        public decimal Price { get; private set; }

        /// <summary>
        /// Get the quantity.
        /// </summary>
        public decimal Quantity { get; private set; }

        /// <summary>
        /// Get the trade timestamp.
        /// </summary>
        public long Timestamp { get; private set; }

        /// <summary>
        /// Get flag indicating if the trade was the best price match.
        /// </summary>
        public bool IsBestPriceMatch { get; private set; }

        #endregion Public Properties

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="id"></param>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        /// <param name="timestamp"></param>
        /// <param name="isBestPriceMatch"></param>
        public Trade(
            string symbol,
            long id,
            decimal price,
            decimal quantity,
            long timestamp,
            bool isBestPriceMatch)
        {
            Throw.IfNullOrWhiteSpace(symbol, nameof(symbol));

            Symbol = symbol;
            Id = id;
            Price = price;
            Quantity = quantity;
            Timestamp = timestamp;
            IsBestPriceMatch = isBestPriceMatch;
        }

        #endregion Constructors
    }
}
