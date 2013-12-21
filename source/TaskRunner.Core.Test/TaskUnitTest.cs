using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using TaskRunner.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskRunner.Core.Test
{
    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    [TestClass]
    public class TaskUnitTest
    {
        [TestMethod]
        public void ShouldInstantiateTask()
        {
            Task task = new Task();
            task.Id = 1001;
            task.MaxDuration = 20;
            task.TaskName = "Unit Test - (ShouldInstantiateTask)";
            task.Executable = "cscript.exe";
            task.Parameters = @"C:\Temp\VBScript\SleepScript.vbs";
            task.Run();
        }

        [TestMethod]
        public void ShouldRunOverMaxDuration()
        {
            Task task = new Task();
            task.Id = 1001;
            task.MaxDuration = 1;
            task.TaskName = "Unit Test - (ShouldRunOverMaxDuration)";
            task.Executable = "cscript.exe";
            task.Parameters = @"C:\Temp\VBScript\SleepScript.vbs";
            task.Run();
        }


    }
}
