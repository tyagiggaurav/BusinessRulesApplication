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

        [TestMethod]
        public void Test_ShouldNotUpdateSlip()
        {
            var rule = new CompositeRule(
        new ActivateRule());
            var book = new Book("book01", "CLRS");
            IReadOnlyCollection<ICommand> commands = rule.Handle(book);
            Assert.AreEqual(commands.Count, 0);
        }

        [TestMethod]
        public void TestActiveMembership()
        {
            var rule = new CompositeRule(
        new ActivateRule());
            var membership = new Membership("regular", "regular membership");
            Assert.AreEqual(false, membership.IsActive);
            IReadOnlyCollection<ICommand> commands = rule.Handle(membership);
            Assert.AreEqual(true, membership.IsActive);

        }

        [TestMethod]
        public void TestUpgradeMembership()
        {
            var rule = new CompositeRule(
        new UpgradeRule());
            var membership = new Membership("regular", "regular membership");
            Assert.AreEqual("Regular", membership.membershipType.ToString());
            IReadOnlyCollection<ICommand> commands = rule.Handle(membership);
            Assert.AreEqual("Premium", membership.membershipType.ToString());
        }

        [TestMethod]
        public void TestCommisionPayment()
        {
            var rule = new CompositeRule(
       new PaymentCommissionRule());
            var physicalProduct = new PhysicalProduct("video1", "video 1");
            Assert.AreEqual(false, physicalProduct.isCommissionGenerated);
            IReadOnlyCollection<ICommand> commands = rule.Handle(physicalProduct);
            Assert.AreEqual(true, physicalProduct.isCommissionGenerated);
        }

    }
}
