// --------------------------------------------------------------------------------------------------------------------
// <copyright company="GroupDocs" file="MatchStats.cs">
//   Copyright (c) 2018 GroupDocs.Assembly for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GroupDocs.Assembly.Cloud.Sdk.Test.DTO
{
    using System.Collections.Generic;

    /// <summary>
    ///     One of classes used to test custom object access while assembling a document.
    /// </summary>
    public class MatchStats
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchStats"/> class.
        /// </summary>
        /// <param name="team1Name">
        /// The team 1 name.
        /// </param>
        /// <param name="team2Name">
        /// The team 2 name.
        /// </param>
        /// <param name="quarterStats">
        /// The quarter stats.
        /// </param>
        public MatchStats(string team1Name, string team2Name, IEnumerable<QuarterStats> quarterStats)
        {
            this.Team1Name = team1Name;
            this.Team2Name = team2Name;
            this.QuarterStats = quarterStats;
        }

        /// <summary>
        ///     Gets or sets the quarter stats.
        /// </summary>
        public IEnumerable<QuarterStats> QuarterStats { get; set; }

        /// <summary>
        ///     Gets or sets the team 1 name.
        /// </summary>
        public string Team1Name { get; set; }

        /// <summary>
        ///     Gets or sets the team 2 name.
        /// </summary>
        public string Team2Name { get; set; }
    }

}