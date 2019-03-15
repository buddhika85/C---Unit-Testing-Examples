using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests_Nunit
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_RetunsTrue()
        {
            // arrange
            var reservation = new Reservation();

            // act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_UserIsMadeByUser_RetunsTrue()
        {
            // arrange
            var reservation = new Reservation { MadeBy = new User { IsAdmin = true } };

            // act
            var result = reservation.CanBeCancelledBy(reservation.MadeBy);

            // assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNotAdmin_RetunsFalse()
        {
            // arrange
            var reservation = new Reservation();

            // act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });

            // assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanBeCancelledBy_UserIsNotMadeByUser_RetunsFalse()
        {
            // arrange
            var reservation = new Reservation { MadeBy = new User { IsAdmin = true } };

            // act
            var result = reservation.CanBeCancelledBy(new User());

            // assert
            Assert.That(result, Is.False);
        }
    }
}
