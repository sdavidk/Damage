﻿using Damage.Gadget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTicker
{
    public class StockTicker : IGadget
    {
        string _output = "";
        public void Initialize()
        {

        }

        public string HTML
        {
            get { return _output; }
        }

        public string Title
        {
            get { return "Stock Ticker"; }
        }

        public string Description
        {
            get { return "Track your important stocks and keep an eye on your portfolio."; }
        }

        public string DefaultSettings
        {
            get { return ""; }
        }

        public List<GadgetSettingField> SettingsSchema
        {
            get { return new List<GadgetSettingField>(); }
        }

        public Damage.DataAccess.Models.UserGadget UserGadget { get; set; }

        public bool InBeta
        {
            get { return true; }
        }
    }
}
