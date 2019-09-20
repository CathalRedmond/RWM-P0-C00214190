using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

using System.Linq;

namespace Tests
{
    public class RunningTotalFilterTests
    {
        [Test]
        public void RunningTotalSimpleTest()
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5 };
            List<int> output = RunningTotalFilter.runningTotal(input);
            List<int> expected = new List<int> { 1, 3, 6, 10, 15 };
            List<int> wrongValue = new List<int> { 14, 9, 5, 3, 1 };

            CollectionAssert.AreNotEqual(output, wrongValue);
            CollectionAssert.AreEqual(output, expected);
        }

        [Test]
        public void RunningTotalBoundaryCasesTest()
        {
            List<int> input = new List<int> { 0, -1, -12, 999999999, -999999999 };
            List<int> output = RunningTotalFilter.runningTotal(input);
            List<int> expected = new List<int> { 0, -1, -13, 999999986, -13 };

            CollectionAssert.AreEqual(output, expected);
        }
    }
}
