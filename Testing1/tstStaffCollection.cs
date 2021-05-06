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

        [TestMethod]
        public void DeleteMethodOK()
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
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.StaffID = 1;
            TestItem.Name = "Filip";
            TestItem.Surname = "Kobeszko";
            TestItem.DateofBirth = Convert.ToDateTime("15/01/2001");
            TestItem.PhoneNumber = "07387666666";
            TestItem.Availability = true;


            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();

            TestItem.StaffID = PrimaryKey;
            TestItem.Name = "Oskar";
            TestItem.Surname = "Karcz";
            TestItem.DateofBirth = Convert.ToDateTime("28/04/2001");
            TestItem.PhoneNumber = "07387444666";
            TestItem.Availability = false;

            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);

            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ReportbySurnameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredSurname = new clsStaffCollection();
            FilteredSurname.ReportBySurname("");
            Assert.AreEqual(AllStaff.Count, FilteredSurname.Count);

        }

        [TestMethod]
        public void ReportbySurnameNoneFound()
        {
            clsStaffCollection FilteredSurname = new clsStaffCollection();
            FilteredSurname.ReportBySurname("abcdefghijklmnopqrstuvwxyz");
            Assert.AreEqual(0, FilteredSurname.Count);

        }

        [TestMethod]
        public void ReportbySurnameDataFound()
        {
            clsStaffCollection FilteredSurname = new clsStaffCollection();
            Boolean OK = true;
            FilteredSurname.ReportBySurname("abcdefghijklmnopqrstuvwxyz");
            if (FilteredSurname.Count == 2)
            {
                if (FilteredSurname.StaffList[0].StaffID != 1)
                {
                    OK = false;
                }
                if (FilteredSurname.StaffList[1].StaffID != 2)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
            

        }
    }
}
