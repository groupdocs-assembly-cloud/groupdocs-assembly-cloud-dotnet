// --------------------------------------------------------------------------------------------------------------------
// <copyright company="GroupDocs" file="QuarterStats.cs">
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
    /// <summary>
    ///     One of classes used to test custom object access while assembling a document.
    /// </summary>
    /// <dev>
    ///     Names of members of this class must satisfy Java naming conventions for autoportability of tests.
    /// </dev>
    public class QuarterStats
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="QuarterStats" /> class.
        /// </summary>
        public QuarterStats()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuarterStats"/> class.
        /// </summary>
        /// <param name="quarter">
        /// The quarter.
        /// </param>
        /// <param name="team1Stats">
        /// The team 1 stats.
        /// </param>
        /// <param name="team2Stats">
        /// The team 2 stats.
        /// </param>
        public QuarterStats(int quarter, TeamStats team1Stats, TeamStats team2Stats)
        {
            this.Quarter = quarter;
            this.Team1Stats = team1Stats;
            this.Team2Stats = team2Stats;
        }

        /// <summary>
        ///     Gets or sets the quarter.
        /// </summary>
        public int Quarter { get; set; }

        /// <summary>
        ///     Gets or sets the team 1 stats.
        /// </summary>
        public TeamStats Team1Stats { get; set; }

        /// <summary>
        ///     Gets or sets the team 2 stats.
        /// </summary>
        public TeamStats Team2Stats { get; set; }
    }

}