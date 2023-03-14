﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class FieldFirmFile
    {
        public long SysId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int? FileSize { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}
