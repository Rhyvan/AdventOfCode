using System;
using System.Collections.Generic;
using AdventOfCode2021.DailyCodes;

namespace AdventOfCode2021
{
    internal class AppFactory
    {
        private static Dictionary<int, Type> Apps = new Dictionary<int, Type>
        {
            { 1, typeof(SonarSweep)}
        };

        public (string first, string second) Run(int dayNumber)
        {
            var success = Apps.TryGetValue(dayNumber, out Type app);
            if (!success) throw new KeyNotFoundException($"Key {dayNumber} not found");

            var instance = (IAppRunner)Activator.CreateInstance(app, dayNumber);

            return instance.GetResult();
        }
    }
}