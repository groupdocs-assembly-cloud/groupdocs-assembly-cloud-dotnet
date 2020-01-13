// --------------------------------------------------------------------------------------------------------------------
// <copyright company="GroupDocs" file="TeamStats.cs">
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
    public class TeamStats
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TeamStats" /> class.
        /// </summary>
        public TeamStats()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamStats"/> class.
        /// </summary>
        /// <param name="points">
        /// The points.
        /// </param>
        /// <param name="pct3Pt">
        /// The pct 3 pt.
        /// </param>
        /// <param name="pctFg">
        /// The pct fg.
        /// </param>
        public TeamStats(int points, float pct3Pt, float pctFg)
        {
            this.Points = points;
            this.Pct3Pt = pct3Pt;
            this.PctFg = pctFg;
        }

        /// <summary>
        ///     Gets or sets the pct 3 pt.
        /// </summary>
        public float Pct3Pt { get; set; }

        /// <summary>
        ///     Gets or sets the pct fg.
        /// </summary>
        public float PctFg { get; set; }

        /// <summary>
        ///     Gets or sets the points.
        /// </summary>
        public int Points { get; set; }
    }
}