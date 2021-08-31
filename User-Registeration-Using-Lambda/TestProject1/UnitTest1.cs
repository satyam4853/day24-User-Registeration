using Microsoft.VisualStudio.TestTools.UnitTesting;
using User_Registeration_Using_Lambda;

namespace TestProject1
{
    [TestClass]

    public class UnitTest1
    {
        public User user;

        [TestInitialize]
        public void SetUp()
        {
            user = new User();
        }
        /// <summary>
        /// Happy TestCases
        /// </summary>
        [TestMethod]
        public void FirstNameValidationShouldReturnTrue()
        {
            //Arrange
            string firstName = "Satyam";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LastNameValidationShouldReturnTrue()
        {
            //Arrange
            string lastName = "Vaishnav";
            //Act
            bool result = user.ValidateLastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailValidationShouldReturnTrue()
        {
            //Arrange
            string email = "satya@gmail.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MobileNumberValidationShouldReturnTrue()
        {
            //Arrange
            string mobileNumber = "91 8446019597";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PasswordValidationShouldReturnTrue()
        {
            //Arrange
            string password = "satya@4853";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// Sad Test Cases
        /// </summary>
        [TestMethod]
        public void FirstNameValidationShouldReturnFalse()
        {
            //Arrange
            string firstName = "Rushikesh";
            //Act
            bool result = user.ValidateFirstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LastNameValidationShouldReturnFalse()
        {
            //Arrange
            string lastName = "Badhe";
            //Act
            bool result = user.ValidateLastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void EmailValidationShouldReturnFalse()
        {
            //Arrange
            string email = "Rushi@gamil.com";
            //Act
            bool result = user.ValidateEmail(email);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void MobileNumberValidationShouldReturnFalse()
        {
            //Arrange
            string mobileNumber = "91 9011519390";
            //Act
            bool result = user.ValidateMobileNumber(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void PasswordValidationShouldReturnFalse()
        {
            //Arrange
            string password = "rushi456";
            //Act
            bool result = user.ValidatePassword(password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateSampleEmailsShouldReturnTrue(string email)
        {
            Assert.IsTrue(user.ValidateEmail(email));
        }
        [TestMethod]
        public void FirstNameValidationShouldReturnException()
        {
            try
            {
                //Arrange
                string firstName = "Satya";
                //Act
                bool result = user.ValidateFirstName(firstName);
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual("It is Invalid", ex.Message);
            }
        }
        [TestMethod]
        public void LastNameValidationShouldReturnException()
        {
            try
            {
                //Arrange
                string lastName = "Vaishnav";
                //Act
                bool result = user.ValidateLastName(lastName);
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual("It is Invalid", ex.Message);
            }
        }
        [TestMethod]
        public void EmailValidationShouldReturnException()
        {
            try
            {
                //Arrange
                string email = "satya@gmail.com";
                //Act
                bool result = user.ValidateEmail(email);
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual("It is Invalid", ex.Message);
            }
        }
        [TestMethod]
        public void MobileNumberValidationShouldReturnException()
        {
            try
            {
                string mobileNumber = "91 8830753557 ";
                bool result = user.ValidateMobileNumber(mobileNumber);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("It is Invalid", ex.Message);
            }
        }
        [TestMethod]
        public void PasswordValidationShouldReturnException()
        {
            try
            {
                //Arrange
                string password = "satya@123";
                //Act
                bool result = user.ValidatePassword(password);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("It is Invalid", ex.Message);
            }
        }
    }
}
