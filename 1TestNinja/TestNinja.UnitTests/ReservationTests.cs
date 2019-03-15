using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_RetunsTrue()
        {
            // arrange
            var reservation = new Reservation();

            // act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsMadeByUser_RetunsTrue()
        {
            // arrange
            var reservation = new Reservation {MadeBy = new User {IsAdmin = true}};

            // act
            var result = reservation.CanBeCancelledBy(reservation.MadeBy);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotAdmin_RetunsFalse()
        {
            // arrange
            var reservation = new Reservation();

            // act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });

            // assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserIsNotMadeByUser_RetunsFalse()
        {
            // arrange
            var reservation = new Reservation { MadeBy = new User { IsAdmin = true } };

            // act
            var result = reservation.CanBeCancelledBy(new User());

            // assert
            Assert.IsFalse(result);
        }
    }
}
