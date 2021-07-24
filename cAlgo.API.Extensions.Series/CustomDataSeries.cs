using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace cAlgo.API.Extensions.Series
{
    public class CustomDataSeries : IndicatorDataSeries
    {
        private readonly Dictionary<int, double> _data = new Dictionary<int, double>();

        public double this[int index]
        {
            get { return _data.ContainsKey(index) ? _data[index] : double.NaN; }
            set
            {
                if ( _data.ContainsKey(index) )
                {
                    _data[index] = value;
                }
                else
                {
                    _data.Add(index, value);
                }
            }
        }

        public double LastValue { get { return _data.Keys.Any() ? _data[_data.Keys.Max()] : double.NaN; } }

        public int Count { get { return _data.Count; } }

    public IEnumerator<double> GetEnumerator() { return _data.Values.GetEnumerator(); }

        public double Last(int lastIndex)
        {
            int index = (Count - 1) - lastIndex;

            return this[index];
        }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }
}