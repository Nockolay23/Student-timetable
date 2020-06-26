﻿using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_Deleted_CTitle
    {
        [TestMethod]
        public void Task_362_1()
        {
            MTitle T_Title = new MTitle("Проф.", "Профессор");
            bool ex = true;
            //act
            RefData.CTitle.Insert(T_Title);
            bool act = RefData.CTitle.Delete(T_Title);
            //assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void Task_362_2()
        {
            //act
            MTitle T_Title = new MTitle("Проф.", "Профессор");
            bool ex = false;
            bool act = RefData.CTitle.Delete(T_Title);
            //assert
            Assert.AreEqual(ex, act);
        }
    }
}
