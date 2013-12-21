using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TaskRunner.Main.Components
{
    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    public partial class TaskRunnerMainController : Component
    {
        public TaskRunnerMainController()
        {
            InitializeComponent();
        }

        public TaskRunnerMainController(IContainer container)
        {
            container.Add(this);
            
            InitializeComponent();
        }
    }
}
