using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass to the method
        string BookName = "Unfinished";
        string AuthorName = "Priyanka Chopra";
        string Price = "11";
        string PublishDate = DateTime.Now.Date.ToString();


        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void AvailablePropertyOK()
        {
            clsStock AStock = new clsStock();
            bool TestData = true;
            AStock.Available = TestData;
            Assert.AreEqual(AStock.Available, TestData);
        }

        [TestMethod]
        public void ProductIdPropertyOK()
        {
            clsStock AStock = new clsStock();
            Int32 TestData = 1;
            AStock.ProductID = TestData;
            Assert.AreEqual(AStock.ProductID, TestData);
        }

        [TestMethod]
        public void BookNamePropertyOK()
        {
            clsStock AStock = new clsStock();
            string TestData = "Unfinished";
            AStock.BookName = TestData;
            Assert.AreEqual(AStock.BookName, TestData);
        }

        [TestMethod]
        public void AuthorNamePropertyOK()
        {
            clsStock AStock = new clsStock();
            string TestData = "Priyanka Chopra";
            AStock.AuthorName = TestData;
            Assert.AreEqual(AStock.AuthorName, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock AStock = new clsStock();
            double TestData = 11;
            AStock.Price = TestData;
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Int32 ProductID = 2;
            Found = AStock.Find(ProductID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //Create instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 2;
            //invoke the methods
            Found = AStock.Find(ProductID);
            //check the Product 
            if (AStock.ProductID != 2)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookNameFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 2;
            //invoke the methods
            Found = AStock.Find(ProductID);
            //check the StaffID 
            if (AStock.BookName != "Riverdale")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAuthorNameFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 2;
            //invoke the methods
            Found = AStock.Find(ProductID);
            //check the Stock 
            if (AStock.AuthorName != "Madeline Cooper")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 2;
            //invoke the methods
            Found = AStock.Find(ProductID);
            //check the StaffID 
            if (AStock.Available != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PriceFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 2;
            //invoke the methods
            Found = AStock.Find(ProductID);
            //check the StaffID 
            if (AStock.Price != 7)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BookNameMinLessOne()
        {
            //Create instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookName = ""; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookNameMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookName = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookName = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookName = ""; //this should be ok
            BookName = BookName.PadRight(19, 'a');
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookNameMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookName = "aaaaaa"; //this should be ok
            BookName = BookName.PadRight(20, 'a');
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookNameMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookName = ""; //this should be ok
            BookName = BookName.PadRight(10,'a');
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BookNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookName = ""; //this should fail
            BookName = BookName.PadRight(51, 'a');
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BookNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookName = ""; //this should fail
            BookName = BookName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AuthorNameMinLessOne()
        {
            //Create instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AuthorName = ""; //this should trigger an error
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AuthorNameMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AuthorName = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AuthorName = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AuthorNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AuthorName = "aaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublishedDateOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = Convert.ToDateTime("09/02/2021");
            AStock.PublishDate = TestData;
            Assert.AreEqual(AStock.PublishDate, TestData);
        }

        [TestMethod]
        public void PublishDateFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Bolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 2;
            //invoke the methods
            Found = AStock.Find(ProductID);
            //check the StaffID 
            if (AStock.PublishDate != Convert.ToDateTime("20/11/2004"))
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PublishDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string PublishDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PublishDateMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string PublishDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublishDateMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string PublishDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PublishDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string PublishDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PublishDateInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PublishDate = "This is not a date!"; //this should fail
            BookName = BookName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AuthorNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string AuthorName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            BookName = BookName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void PriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            double TestPrice;
            //set the date todays date 
            TestPrice = -10000000;
            //change the date to whatever the date is less 100years
            //convert the date variable to a string varaible
            string Price = TestPrice.ToString();
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            double TestPrice;
            //set the date todays date 
            TestPrice = -0.01;
            //change the date to whatever the date is less 100years
            //convert the date variable to a string varaible
            string Price = TestPrice.ToString();
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            double TestPrice;
            //set the date todays date 
            TestPrice = 0.00;
            //change the date to whatever the date is less 100years
            //convert the date variable to a string varaible
            string Price = TestPrice.ToString();
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            double TestPrice;
            //set the date todays date 
            TestPrice = 0.01;
            //change the date to whatever the date is less 100years
            //convert the date variable to a string varaible
            string Price = TestPrice.ToString();
            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method

            string Price = "This is not a price: ";

            //invoke the method
            Error = AStock.Valid(BookName, AuthorName, Price, PublishDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
    }
}
