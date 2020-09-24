namespace InvoiceTest.Data.Tests
{
    using InvoiceTest;
    using System;
    using NUnit.Framework;
    using Microsoft.EntityFrameworkCore;
    using InvoiceTest.Models;

    [TestFixture]
    public class InvoiceContextTests
    {
        private InvoiceContext _testClass;
        private DbContextOptions<InvoiceContext> _options;

        [SetUp]
        public void SetUp()
        {
            _options = new DbContextOptions<InvoiceContext>();
            _testClass = new InvoiceContext(_options);
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new InvoiceContext(_options);
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CannotConstructWithNullOptions()
        {
            Assert.Throws<ArgumentNullException>(() => new InvoiceContext(default(DbContextOptions<InvoiceContext>)));
        }

        [Test]
        public void CanSetAndGetItems()
        {
            var testValue = new DbSet<Item>();
            _testClass.Items = testValue;
            Assert.That(_testClass.Items, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetUnits()
        {
            var testValue = new DbSet<Unit>();
            _testClass.Units = testValue;
            Assert.That(_testClass.Units, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetStores()
        {
            var testValue = new DbSet<Store>();
            _testClass.Stores = testValue;
            Assert.That(_testClass.Stores, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetInvoices()
        {
            var testValue = new DbSet<Invoice>();
            _testClass.Invoices = testValue;
            Assert.That(_testClass.Invoices, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetInvoiceDetails()
        {
            var testValue = new DbSet<InvoiceDetail>();
            _testClass.InvoiceDetails = testValue;
            Assert.That(_testClass.InvoiceDetails, Is.EqualTo(testValue));
        }
    }
}