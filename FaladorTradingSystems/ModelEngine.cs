﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Engine
{
    public class ModelEngine
    {
        #region constructor

        public ModelEngine()
        {
            AssetPriceData = AssetPriceDataLoader.LoadData(ProjectParameters.DataFileLocation);
        }

        #endregion

        #region properties

        public MarketData AssetPriceData { get; }

        #endregion

        #region methods

        public AssetDataSeries GetPriceSeries()
        {
            return AssetPriceData.First<AssetDataSeries>();
        }


        #endregion
    }
}
