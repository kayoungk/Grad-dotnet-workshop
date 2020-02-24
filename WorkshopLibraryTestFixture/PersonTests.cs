using System;
using WorkshopLibrary;
using Xunit;

namespace WorkshopLibraryTestFixture
{
    public class PersonTests
    {
        [Fact]
        public void GivenAValidFirstNameAndLastName_ReturnsExpectedDisplayName()
        {
            //Arrange

            //act

            //assert
        }

        [Fact]
        public void GivenAValidDoB_ReturnsExpectedAge()
        {
            var person = new Person { DoB = new DateTime(1980, 4, 8) };
            var expectedAge = 39;

            var actualAge = person.Age;

            Assert.Equal(expectedAge, actualAge);

        }
    }
}
