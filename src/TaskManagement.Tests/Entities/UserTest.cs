﻿using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Exceptions;
using TaskManagement.Tests.Shared.Fixtures.Entities;
using Xunit;

namespace TaskManagement.Tests.Entities
{
    public class UserTest
    {
        [Fact]
        public void IsUserValid_ThenResultTrue()
        {
            // Arange
            User user = UserFixtures.New().Builder();

            // Act
            var userResult = user.IsValid();

            // Assert
            Assert.True(userResult);
        }

        [Fact]
        public void IsNameUserInValid_ThenNameInvalid()
        {
            // Arange
            string name = "";
            string message = "Name invalid";
            User user = UserFixtures.New().WithName(name).Builder();

            // Act
            var userResult = user.Validate().FirstOrDefault();

            // Assert
            Assert.Equal(message, userResult);
        }

        [Fact]
        public void IsLastNameUserInValid_ThenLastNameInvalid()
        {
            // Arange
            string lastName = "";
            string message = "Last Name invalid";
            User user = UserFixtures.New().WithLastName(lastName).Builder();

            // Act
            var userResult = user.Validate().FirstOrDefault();

            // Assert
            Assert.Equal(message, userResult);
        }

        [Fact]
        public void IsEmailUserInValid_ThenEmailInvalid()
        {
            // Arange
            string email = "";
            string message = "Email invalid";
            User user = UserFixtures.New().WithEmail(email).Builder();

            // Act
            var userResult = user.Validate().FirstOrDefault();

            // Assert
            Assert.Equal(message, userResult);
        }

        [Fact]
        public void WhenUserInValid_ThenReturnTaskManagementException()
        {
            // Arange
            string email = "";
            User userInValid = UserFixtures.New().WithEmail(email).Builder();

            // Assert
            Assert.Throws<TaskManagementException>(() => userInValid.ValidateEntities());
        }
    }
}
