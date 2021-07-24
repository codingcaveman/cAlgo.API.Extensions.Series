﻿using cAlgo.API.Extensions.Series.Enums;
using System;

namespace cAlgo.API.Extensions.Series.Models
{
    public class OhlcBar
    {
        public int Index { get; set; }

        public DateTime Time { get; set; }
        public double Open { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public double Close { get; set; }

        public double Volume { get; set; }

        public BarType Type
        {
            get
            {
                if (Open < Close)
                {
                    return BarType.Bullish;
                }
                else if (Open > Close)
                {
                    return BarType.Bearish;
                }
                else
                {
                    return BarType.Neutral;
                }
            }
        }
    }
}