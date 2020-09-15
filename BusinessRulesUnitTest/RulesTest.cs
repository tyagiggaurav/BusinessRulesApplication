using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRules;
using BusinessRules.Products;
using BusinessRules.Rules;
using BusinessRules.Commands;

namespace BusinessRulesUnitTest
{
    [TestClass]
    public class RulesTest
    {
        [TestMethod]
        public void TestForBookProducts()
        {
            var rule = new CompositeRule(new SlipForShippingRule(),
                new SlipForRoyaltyRule());
            var book = new Book("book01", "CLRS");
            IReadOnlyCollection<ICommand> commands = rule.Handle(book);
            // Shall return 2 objects, for shipping and royality department
            Assert.AreEqual(commands.Count, 2);
        }
    }
}
