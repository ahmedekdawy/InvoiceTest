namespace InvoiceTest.Data.Tests.Migrations
{
    using InvoiceTest.Data.Migrations;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class InvoiceContextModelSnapshotTests
    {
        private InvoiceContextModelSnapshot _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new InvoiceContextModelSnapshot();

        }

        [Test]
        public void CanConstruct()
        {
            var instance = new InvoiceContextModelSnapshot();
            Assert.That(instance, Is.Not.Null);
        }
    }
}