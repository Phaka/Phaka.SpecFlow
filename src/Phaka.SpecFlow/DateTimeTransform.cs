#region License

// The MIT License (MIT)
// 
// Copyright (c) 2017 Werner Strydom
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

#endregion

namespace Phaka.SpecFlow
{
    using System;
    using TechTalk.SpecFlow;

    /// <summary>
    ///     Represents methods to transform strings into dates
    /// </summary>
    [Binding]
    public class DateTimeTransform
    {
        /// <summary>
        ///     Transforms an expression of a few days from now into a date time
        /// </summary>
        /// <param name="days">The number of days</param>
        /// <returns>The DateTime <see cref="days" /> in the future</returns>
        [StepArgumentTransformation(@"in (\d+) days?")]
        public DateTime InXDaysTransform(int days)
        {
            return DateTime.Today.AddDays(days);
        }

        /// <summary>
        ///     Transforms an expression of a few years from now into a date time
        /// </summary>
        /// <param name="years">The number of years</param>
        /// <returns>The DateTime <see cref="years" /> in the future</returns>
        [StepArgumentTransformation(@"in (\d+) years?")]
        public DateTime InXYearsTransform(int years)
        {
            return DateTime.Today.AddDays(years);
        }
    }
}