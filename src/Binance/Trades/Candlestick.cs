﻿namespace Binance
{
    /// <summary>
    /// Candlestick.
    /// </summary>
    public sealed class Candlestick
    {
        #region Public Properties

        /// <summary>
        /// Get the symbol.
        /// </summary>
        public string Symbol { get; private set; }

        /// <summary>
        /// Get the interval.
        /// </summary>
        public KlineInterval Interval { get; private set; }

        /// <summary>
        /// Get the open time.
        /// </summary>
        public long OpenTime { get; private set; }

        /// <summary>
        /// Get the open price in quote asset units.
        /// </summary>
        public decimal Open { get; private set; }

        /// <summary>
        /// Get the high price in quote asset units.
        /// </summary>
        public decimal High { get; private set; }

        /// <summary>
        /// Get the low price in quote asset units.
        /// </summary>
        public decimal Low { get; private set; }

        /// <summary>
        /// Get the close price in quote asset units.
        /// </summary>
        public decimal Close { get; private set; }

        /// <summary>
        /// Get the volume in base asset units.
        /// </summary>
        public decimal Volume { get; private set; }

        /// <summary>
        /// Get the close time.
        /// </summary>
        public long CloseTime { get; private set; }

        /// <summary>
        /// Get the volume in quote asset units.
        /// </summary>
        public decimal QuoteAssetVolume { get; private set; }

        /// <summary>
        /// Get the number of trades.
        /// </summary>
        public long NumberOfTrades { get; private set; }

        /// <summary>
        /// Get the taker buy base asset volume.
        /// </summary>
        public decimal TakerBuyBaseAssetVolume { get; private set; }

        /// <summary>
        /// Get the taker buy quote asset volume.
        /// </summary>
        public decimal TakerBuyQuoteAssetVolume { get; private set; }

        #endregion Public Properties

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <param name="interval">The interval.</param>
        /// <param name="openTime">The open time.</param>
        /// <param name="open">The open price.</param>
        /// <param name="high">The high price.</param>
        /// <param name="low">The low price.</param>
        /// <param name="close">The close price.</param>
        /// <param name="volume">The volume in base asset units.</param>
        /// <param name="closeTime">The close time.</param>
        /// <param name="quoteAssetVolume">The volume in quote assset units.</param>
        /// <param name="numberOfTrades">The number of trades.</param>
        /// <param name="takerBuyBaseAssetVolume">The taker buy base asset volume.</param>
        /// <param name="takerBuyQuoteAssetVolume">The taker buy quote asset volume.</param>
        public Candlestick(
            string symbol,
            KlineInterval interval,
            long openTime,
            decimal open,
            decimal high,
            decimal low,
            decimal close,
            decimal volume,
            long closeTime,
            decimal quoteAssetVolume,
            long numberOfTrades,
            decimal takerBuyBaseAssetVolume,
            decimal takerBuyQuoteAssetVolume)
        {
            Symbol = symbol;
            Interval = interval;
            OpenTime = openTime;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
            CloseTime = closeTime;
            QuoteAssetVolume = quoteAssetVolume;
            NumberOfTrades = numberOfTrades;
            TakerBuyBaseAssetVolume = takerBuyBaseAssetVolume;
            TakerBuyQuoteAssetVolume = takerBuyQuoteAssetVolume;
        }

        #endregion Constructors
    }
}
