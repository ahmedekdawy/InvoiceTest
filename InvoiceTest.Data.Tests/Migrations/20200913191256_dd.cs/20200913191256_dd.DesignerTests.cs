namespace InvoiceTest.Data.Tests.Migrations
{
    using InvoiceTest.Data.Migrations;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ddTests
    {
        private dd _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new dd();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new dd();
            Assert.That(instance, Is.Not.Null);
        }
    }
}