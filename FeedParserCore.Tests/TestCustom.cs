﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FeedParserCore.Tests
{
    [TestClass]
    [TestCategory("Custom")]
    public class TestCustom
    {
        private const string testString = "test";

        [TestMethod]
        public async Task ItemHandler()
        {
            var feed = await FeedParser.ParseAsync("Samples/testrss.rss", FeedType.RSS, (x) => new FeedItem
            {
                Content = testString
            });
            Assert.IsTrue(feed.All(f => f.Content == testString));
        }
    }
}
