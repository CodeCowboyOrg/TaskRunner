using TaskRunner.Core;
using TaskRunner.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace TaskRunner.Core.Test
{


    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    [TestClass()]
    public class TaskGroupTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for TaskGroup Constructor
        ///</summary>
        [TestMethod()]
        public void TaskGroupConstructorTest()
        {
            TaskGroup target = new TaskGroup();
        }

        /// <summary>
        ///A test for Run
        ///</summary>
        [TestMethod()]
        public void RunTest()
        {
            Task task1 = new Task();
            task1.Id = 1001;
            task1.MaxDuration = 1;
            task1.TaskName = "Unit Test 1001";
            task1.Executable = "cscript.exe";
            task1.Parameters = @"C:\Temp\VBScript\SleepScript.vbs";

            Task task2 = new Task();
            task2.Id = 1002;
            task2.MaxDuration = 2;
            task2.TaskName = "Unit Test 1002";
            task2.Executable = "cscript.exe";
            task2.Parameters = @"C:\Temp\VBScript\SleepScript.vbs";

            TaskGroup target = new TaskGroup();
            target.TaskList.Add(task1);
            target.TaskList.Add(task2);
            target.Run();
        }

        /// <summary>
        ///A test for Serialize
        ///</summary>
        [TestMethod]
        public void ShouldSerialize()
        {
            Task task1 = new Task();
            task1.Id = 1001;
            task1.MaxDuration = 1;
            task1.TaskName = "Unit Test 1001";
            task1.Executable = "cscript.exe";
            task1.Parameters = @"C:\Temp\VBScript\SleepScript.vbs";

            Task task2 = new Task();
            task2.Id = 1002;
            task2.MaxDuration = 2;
            task2.TaskName = "Unit Test 1002";
            task2.Executable = "cscript.exe";
            task2.Parameters = @"C:\Temp\VBScript\SleepScript.vbs";

            TaskGroup tg1 = new TaskGroup();
            tg1.TaskList.Add(task1);
            tg1.TaskList.Add(task2);

            XmlSerializer<TaskGroup>.Serialize(@"C:\Temp\TaskGroupTest1.xml", tg1);

            TaskGroup tg2 = XmlSerializer<TaskGroup>.Deserialize(@"C:\Temp\TaskGroupTest1.xml");
            Assert.IsTrue(tg2.TaskList.Count > 0);
        }

        /// <summary>
        ///A test for TaskList
        ///</summary>
        [TestMethod()]
        public void TaskListTest()
        {
            TaskGroup target = new TaskGroup();
            List<Task> expected = null;
            List<Task> actual;
            target.TaskList = expected;
            actual = target.TaskList;
            Assert.AreEqual(expected, actual);
        }
    }
}
