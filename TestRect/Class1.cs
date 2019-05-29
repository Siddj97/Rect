using System;



namespace TestRect
{
    public class Class1
    {
        [Test]
        public void GetLength_Input88_Returns88()
        {

            //Arrange
            int length = 88;
            int width = 16;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetLength();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetWidth_Input65_Returns65()
        {

            //Arrange
            int length = 18;
            int width = 65;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetWidth();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetLength_Input89_Returns89()
        {

            //Arrange
            int length = 89;
            int width = 14;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.SetLength(length);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Setwidth_Input36_Returns36()
        {

            //Arrange
            int length = 16;
            int width = 36;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.SetWidth(width);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input_Length12And_Width24_Returns72()
        {

            //Arrange
            int length = 12;
            int width = 24;

            int expectedResult = 2 * (length + width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetPerimeter();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input_Length20And_Width25_Returns500()
        {

            //Arrange
            int length = 20;
            int width = 25;

            int expectedResult = (length * width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetArea();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}


