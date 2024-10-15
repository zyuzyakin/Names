using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{   

    public class PieSeriesData
    {
        public string Title { get; }
        public Dictionary<string, int> Data { get; }
        public PieSeriesData(string title, Dictionary<string, int> data)
        {
            Title = title;
            Data = data;
        }
        
    }

    
}
