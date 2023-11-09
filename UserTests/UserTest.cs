using LaunchMod1Week5Assessment;

namespace UserTests
{
    public class UserTest
    {
        [Fact]
        public void User_IsCreated()
        {
            User asher = new User("Asher", "fancyemail@gmail.com");

            Assert.Equal("Asher", asher.Name);
            Assert.Equal("fancyemail@gmail.com", asher.Email);
        }

        [Fact]
        public void IsSetUpComplete_False() 
        {
            User asher = new User("Asher", "fancyemail@gmail.com");

            Assert.False(asher.IsSetupComplete()); //Found a fun new way to test a boolean!
            //Assert.Equal(false, asher.IsSetupComplete());
        }
        [Fact]
        public void IsSetUpComplete_True()
        {
            User asher = new User("Asher", "fancyemail@gmail.com");

            asher.CreatePassword("fancyemail@gmail.com", "VeryFancyPassword");

            Assert.True(asher.IsSetupComplete()); 
           
        }

        [Fact]
        public void CreatePassword_IsAssignedToPassword()
        {
            User asher = new User("Asher", "fancyemail@gmail.com");

            asher.CreatePassword("fancyemail@gmail.com", "VeryCreativePassword");

            Assert.Equal("Password Created", asher.CreatePassword("fancyemail@gmail.com", "VeryCreativePassword"));
        }

        [Fact]
        public void LogIn_ReturnStringLoggedInOrNotLoggedIn()
        {
            User asher = new User("Asher", "fancyemail@gmail.com");
            User jensen = new User("Jensen", "superfancyemail@gmail.com");

            asher.CreatePassword("fancyemail@gmail.com", "VeryCreativePassword");
            jensen.CreatePassword("superfancyemail@gmail.com", "VeryCreativePassword");

            Assert.Equal("Logged In", asher.LogIn("VeryCreativePassword"));
            Assert.Equal("Not Logged In", jensen.LogIn("NotCorrectPassword"));
        }

        [Fact]
        public void LogOut_LogsPersonOut()
        {
            User asher = new User("Asher", "fancyemail@gmail.com");

            asher.CreatePassword("fancyemail@gmail.com", "VeryCreativePassword");

            asher.LogIn("VeryCreativePassword");
            asher.LogOut();

            Assert.False(asher.LogOut());
        }
    }
}