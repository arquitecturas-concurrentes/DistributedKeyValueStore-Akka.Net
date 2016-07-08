﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IASC.DistributedKeyValueStore.Common
{
    public class SearchMessage
    {
        public string ValueToCompare { get; private set; }

        /// <summary>
        /// For example "ge"
        /// g: greater
        /// e: equal
        /// l: lower
        /// </summary>
        public string Comparison { get; private set; }

        public SearchMessage(string valueToCompare, string comparison)
        {
            ValueToCompare = valueToCompare;
            Comparison = comparison;
        }
    }
}