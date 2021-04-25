using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();

            TestItem.Availability = true;
            TestItem.DateofBirth = Convert.ToDateTime("15/01/2001");
            TestItem.Name = "Filip";
            TestItem.Surname = "Kobeszko";
            TestItem.PhoneNumber = "07387666666";
            TestItem.StaffID = 1;

            TestList.Add(TestItem);

            AllStaff.StaffList = TestList;



            Assert.AreEqual(AllStaff.StaffList, TestList);
        }


        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestStaff = new clsStaff();

            TestStaff.Availability = true;
            TestStaff.DateofBirth = Convert.ToDateTime("15/01/2001");
            TestStaff.Name = "Filip";
            TestStaff.Surname = "Kobeszko";
            TestStaff.PhoneNumber = "07387666666";
            TestStaff.StaffID = 1;

            AllStaff.ThisStaff = TestStaff;



            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();

            TestItem.Availability = true;
            TestItem.DateofBirth = Convert.ToDateTime("15/01/2001");
            TestItem.Name = "Filip";
            TestItem.Surname = "Kobeszko";
            TestItem.PhoneNumber = "07387666666";
            TestItem.StaffID = 1;

            TestList.Add(TestItem);

            AllStaff.StaffList = TestList;



            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Availability = true;
            TestItem.DateofBirth = Convert.ToDateTime("15/01/2001");
            TestItem.Name = "Filip";
            TestItem.Surname = "Kobeszko";
            TestItem.PhoneNumber = "07387666666";
            TestItem.StaffID = 1;


            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            TestItem.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

    }
}
