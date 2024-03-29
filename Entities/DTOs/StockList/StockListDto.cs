﻿using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.StockList
{
    public class StockListDto : IDto
    {
        public int? Id { get; set; }
        public string? StockCode { get; set; }

        public int? Amount { get; set; }

        public string? ShelfCode { get; set; }

        public string? CabinetCode { get; set; }

        public int? CriticalAmount { get; set; }

        public string? StockTypeName { get; set; }

    }
}
