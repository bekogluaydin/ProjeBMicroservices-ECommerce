using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Shared.Messages
{
    public class CourseNameChangedEvent
    {
        public string CourseId { get; set; }
        public string UpdateName { get; set; }
    }
}
