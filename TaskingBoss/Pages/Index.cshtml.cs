﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TaskingBoss.Core;
using TaskingBoss.Data;

namespace TaskingBoss.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ITaskData _taskData;

        public List<TaskItem> Tasks { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ITaskData taskData)
        {
            _logger = logger;
            _taskData = taskData;
        }

        public void OnGet()
        {
            Tasks = _taskData.GetTasks();
        }
    }
}
