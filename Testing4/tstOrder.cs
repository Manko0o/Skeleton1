using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace Test_Framework
{
    [TestClass]
    public class tstOrder
    {
        string BookName = "The Good Times";
        string Quantity = "2";
        string OrderDate = DateTime.Now.Date.ToString();
        string Price = "20";



        [TestMethod]

        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookNameMinOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string BookName = "";
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookNameMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string BookName = "bb";
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BookNameMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string BookName = "bbbbb";
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookNameMax()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string BookName = "bbbbbb";
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookNameMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookName = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void BookNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookName = "aaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void BookNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BookName = "aaaaaaaa"; //this should be ok
            BookName = BookName.PadRight(500, 'b');
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

   

        [TestMethod]
        public void QuantityMinOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "1";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "11";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "1111111";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "123456789";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "123456789";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "1";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PriceMinOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "1";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "11";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "1111111";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "123456789";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Price = "";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Quantity = "1";
            //invoke the method
            Error = AnOrder.Valid(BookName, Quantity, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
    }



    namespace Testing4
    {
        [TestClass]
        public class tstOrder
        {

            [TestMethod]
            public void OrderNoPropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                Int32 TestData = 1;
                //assign the data to the property
                AnOrder.OrderNo = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.OrderNo, TestData);
            }



            [TestMethod]
            public void InstanceOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //test to see that it exists
                Assert.IsNotNull(AnOrder);
            }

            [TestMethod]
            public void BookNamePropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                string TestData = "A Life Without Degree";
                //assign the data to the property
                AnOrder.BookName = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.BookName, TestData);

            }

            [TestMethod]
            public void QuantityPropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                Int32 TestData = 10;
                //assign the data to the property
                AnOrder.Quantity = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.Quantity, TestData);
            }


            [TestMethod]
            public void OrderDatePropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                DateTime TestData = DateTime.Now.Date;
                //assign the data to the property
                AnOrder.OrderDate = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.OrderDate, TestData);
            }


            [TestMethod]
            public void PricePropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                double TestData = 4;
                //assign the data to the property
                AnOrder.Price = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.Price, TestData);
            }


            [TestMethod]
            public void DispatchedPropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                Boolean TestData = true;
                //assign the data to the property
                AnOrder.Dispatched = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.Dispatched, TestData);
            }

            [TestMethod]
            public void FindMethodOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //Boolean variable to store the results of the validatio
                Boolean Found = false;
                //create some test data to use with the method
                Int32 OrderNo = 1;
                //invoke the method
                Found = AnOrder.Find(OrderNo);
                //test to see if the result is true
                Assert.IsTrue(Found);
            }

            [TestMethod]
            public void TestQuantityFound()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK 
                Boolean OK = false;
                //create some test data to use with the method
                Int32 Quantity = 10;
                //invoke the method
                Found = AnOrder.Find(Quantity);
                //check the address no
                if (AnOrder.Quantity != 10)
                {
                    OK = true;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestOrderDateFound()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK 
                Boolean OK = true;
                //create some test data to use with the method
                Int32 Quantity = 10;
                //invoke the method
                Found = AnOrder.Find(Quantity);
                //check the address no
                if (AnOrder.OrderDate != Convert.ToDateTime("07/02/2021"))
                {
                    OK = true;

                }
                //test to see that the result is correct
                Assert.IsTrue(OK);

            }


            [TestMethod]
            public void BookNameFound()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 OrderNo = 1; 
                //invoke the method
                Found = AnOrder.Find(OrderNo);
                //check the property
                if (AnOrder.BookName != "The Good Times")
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }



            [TestMethod]
            public void PriceFound()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 OrderNo = 1; 
                //invoke the method
                Found = AnOrder.Find(OrderNo);
                //check the property
                if (AnOrder.Price != 20)
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }



            [TestMethod]
            public void TestOrderNoFound()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK 
                Boolean OK = true;
                //create some test data to use with the method
                Int32 OrderNo = 1;
                //invoke the method
                Found = AnOrder.Find(OrderNo);
                //check the address no
                if (AnOrder.OrderNo != 1)
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestDispatchedFound()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 OrderNo = 1;
                //invoke the method
                Found = AnOrder.Find(OrderNo);
                //check the property
                if (AnOrder.Dispatched != true)
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);


            }
        }
    }
}
















