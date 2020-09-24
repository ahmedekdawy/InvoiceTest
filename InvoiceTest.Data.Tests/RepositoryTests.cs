namespace InvoiceTest.Data.Tests
{
    using InvoiceTest.Data;
    using T = System.String;
    using System;
    using NUnit.Framework;
    using InvoiceTest;
    using Microsoft.EntityFrameworkCore;

    [TestFixture]
    public class Repository_1Tests
    {
        private Repository<T> _testClass;
        private InvoiceContext _context;

        [SetUp]
        public void SetUp()
        {
            _context = new InvoiceContext(new DbContextOptions<InvoiceContext>());
            _testClass = new Repository<T>(_context);
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new Repository<T>(_context);
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CannotConstructWithNullContext()
        {
            Assert.Throws<ArgumentNullException>(() => new Repository<T>(default(InvoiceContext)));
        }

        [Test]
        public void CanCallGetAll()
        {
            var result = _testClass.GetAll();
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanCallGet()
        {
            var id = 814451530L;
            var result = _testClass.Get(id);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanCallInsert()
        {
            var entity = "TestValue1152135225";
            _testClass.Insert(entity);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallInsertWithNullEntity()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.Insert(default(T)));
        }

        [Test]
        public void CanCallUpdate()
        {
            var entity = "TestValue1309823805";
            _testClass.Update(entity);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallUpdateWithNullEntity()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.Update(default(T)));
        }

        [Test]
        public void CanCallDelete()
        {
            var entity = "TestValue1264634931";
            _testClass.Delete(entity);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallDeleteWithNullEntity()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.Delete(default(T)));
        }

        [Test]
        public void CanCallRemove()
        {
            var entity = "TestValue468986424";
            _testClass.Remove(entity);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallRemoveWithNullEntity()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.Remove(default(T)));
        }

        [Test]
        public void CanCallSaveChanges()
        {
            _testClass.SaveChanges();
            Assert.Fail("Create or modify test");
        }
    }
}