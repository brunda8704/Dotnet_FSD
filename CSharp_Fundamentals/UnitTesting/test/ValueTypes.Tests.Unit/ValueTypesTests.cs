using FluentAssertions;
using System.Configuration;

namespace ValueTypes.Tests.Unit
{
    public class ValueTypesTests
    {
        //sut-> system under test
        Person _sut = new Person();
        User _sutOne  = new User();
        

        [Fact]
        public void PersonAssertion()
        {
            var fullName = _sut.FullName;
            fullName.Should().Be("Brunda Mahesh");  
            fullName.Should().NotBeNull();
            fullName.Should().StartWith("Brunda");
            fullName.Should().EndWith("Mahesh");
        }



        [Fact]

        public void UserAssertion()
        {
            var expected = new User()
            {
                Name = "Brunda",
                Age= 25

            };
            _sutOne.Should().BeEquivalentTo(expected);
            
        }
        
    }
}