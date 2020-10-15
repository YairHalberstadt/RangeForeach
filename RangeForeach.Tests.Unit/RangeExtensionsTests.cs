using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace RangeForeach.Tests.Unit
{
    public class RangeExtensionsTests
    {
        [Fact]
        public void CanForeachOnRange()
        {
            var items = new List<int>();
            foreach(var i in 7..13)
            {
                items.Add(i);
            }

            Assert.Equal(new[] { 7, 8, 9, 10, 11, 12 }, items);
        }

        [Fact]
        public void ErrorIfStartIsFromIndex()
        {
            var items = new List<int>();
            Assert.Throws<ArgumentException>(() => { foreach (var i in ^7..13) { } });
        }

        [Fact]
        public void ErrorIfEndIsFromIndex()
        {
            var items = new List<int>();
            Assert.Throws<ArgumentException>(() => { foreach (var i in 7..^13) { } });
        }

        [Fact]
        public void ErrorIfStartAndEndIsFromIndex()
        {
            var items = new List<int>();
            Assert.Throws<ArgumentException>(() => { foreach (var i in ^7..^13) { } });
        }

        [Fact]
        public void ErrorIfStartIsNegative()
        {
            var items = new List<int>();
            Assert.Throws<ArgumentOutOfRangeException>(() => { foreach (var i in -7..13) { } });
        }

        [Fact]
        public void ErrorIfEndIsNegative()
        {
            var items = new List<int>();
            Assert.Throws<ArgumentOutOfRangeException>(() => { foreach (var i in 7..-13) { } });
        }

        [Fact]
        public void ErrorIfStartAndEndIsNegative()
        {
            var items = new List<int>();
            Assert.Throws<ArgumentOutOfRangeException>(() => { foreach (var i in -7..-6) { } });
        }

        [Fact]
        public void ErrorIfStartIsGreaterThanEnd()
        {
            var items = new List<int>();
            Assert.Throws<ArgumentException>(() => { foreach (var i in 1..0) { } });
        }

        [Fact]
        public void StartCanBeSameAsEnd()
        {
            var items = new List<int>();
            foreach (var i in 0..0)
            {
                items.Add(i);
            }
            Assert.Empty(items);
        }
    }
}
