using System.Collections.Generic;
using Utility;

namespace AdventOfCode2021.DailyCodes
{
    /// <summary>
    /// Generic type is responsible for data's type held by an IEnumerable.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractApp<T> : IAppRunner
    {
        private readonly string _notCalc = "not calculated";
        protected readonly string _fileName;
        protected IEnumerable<T> _data;

        public AbstractApp(int dayNumber)
        {
            _fileName = $"Day{dayNumber:D2}.txt";
        }

        public (string first, string second) GetResult()
        {
            _data = GetDataFromSource.Get<T>(_fileName);
            var first = GetFirstResult() ?? _notCalc;
            var second = GetSecondResult() ?? _notCalc;

            return (first, second);
        }

        public abstract string GetFirstResult();
        public abstract string GetSecondResult();
    }
}
