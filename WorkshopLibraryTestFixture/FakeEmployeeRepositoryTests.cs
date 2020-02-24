using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WorkshopLibrary;
using Xunit;

namespace WorkshopLibraryTestFixture
{
   public class FakeEmployeeRepositoryTests
    {
        [Fact]
        public void CreateNewRepositoryWith10EmployeesDefined_Returns10Employees()
        {
            var repository = new FakeEmployeeRepository(10);

            var employees = repository.GetAll();

            Assert.Equal(10, employees.Count);
        }

        [Fact]
        public void GivenAValidRepository_ShouldContainAtLeastOneManager()
        {
            var repository = new FakeEmployeeRepository(10);
            
            var managers = repository.GetAll().Where(e => e is IManager);

            Assert.NotEmpty(managers);
        }

        [Fact]
        public void GivenAValidManager_ShouldContainCollectionOfEmployeeIds()
        {
            var repository = new FakeEmployeeRepository(10);

            var manager = repository.GetAll().First(e => e is IManager) as IManager;

            Assert.NotEmpty(manager.Employees);
        }
    }
}
