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
            var firstName = "Bob";
            var lastName = "Jones";
            var expectedDisplayName = "Bob Jones";
            var person = new Person { FirstName = firstName, LastName = lastName };
            //act
            var actualDisplayName = person.DisplayName();

            //assert
            Assert.Equal(expectedDisplayName, actualDisplayName);
        }

        [Fact]
        public void GivenInvalidFirstNameAndLastName_ReturnsUnknownUser()
        {
            var person = new Person();
            var expectedValue = "Unknown User";

            Assert.Equal(expectedValue, person.DisplayName());

        }

        [Fact]
        public void GivenInvalidFirstNameAndVaildLastName_ReturnsstarsFirstName()
        {
            var person = new Person { LastName = "Jones" };
            var expectedValue = "***** Jones";

            Assert.Equal(expectedValue, person.DisplayName());

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
