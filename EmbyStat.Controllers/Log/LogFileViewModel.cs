﻿using System;

namespace EmbyStat.Controllers.Log
{
    public class LogFileViewModel
    {
        public string FileName { get; set; }
        public DateTime CreatedDate { get; set; }
        public long Size { get; set; }
    }
}
