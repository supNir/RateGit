using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Rate
{
    public class Rates
    {
        public static decimal SumRate(decimal t, decimal V, decimal k)
        {
            // comment for commit
            // new comment for Задача 1
            // change for pull request
            return (V * t * (k / 100) + V);
        }
    }
}


