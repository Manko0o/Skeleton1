using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Int32 Quantity = 10;
            //invoke the method
            Found = AnOrder.Find(Quantity);
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
                OK = false;

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
                Int32 Quantity = 10; ;
                //invoke the method
                Found = AnOrder.Find(Quantity);
                //check the property
                if (AnOrder.BookName != "A Life Without Degree")
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
            Int32 Quantity = 10; ;
            //invoke the method
            Found = AnOrder.Find(Quantity);
            //check the property
            if (AnOrder.Price != 7)
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
            Int32 Quantity = 10;
            //invoke the method
            Found = AnOrder.Find(Quantity);
            //check the address no
            if (AnOrder.OrderNo != 4)
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
            Int32 Quantity = 10;
            //invoke the method
            Found = AnOrder.Find(Quantity);
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
















