﻿using Core.Entities;
using Entities.Concrete;
using Entities.DTOs.StockType;

namespace Entities.DTOs.StockUnit
{
    public class StockUnitDto : IDto
    {
        public int Id { get; set; }

        public string? StockCode { get; set; }

        public StockTypeDto StockType { get; set; }

        public int IdQuantityUnit { get; set; }

        public string? Description { get; set; }

        public decimal? PurchasePrice { get; set; }

        public int? IdCurrencyTypePurchase { get; set; }

        public decimal? SalePrice { get; set; }

        public int? IdCurrencyTypeSale { get; set; }

        public decimal? Weight { get; set; }

        public bool Deleted { get; set; }

        public virtual CurrencyType? IdCurrencyTypePurchaseNavigation { get; set; }

        public virtual CurrencyType? IdCurrencyTypeSaleNavigation { get; set; }

        public virtual QuantityUnit IdQuantityUnitNavigation { get; set; } = null!;

        //public virtual StockType IdStockTypeNavigation { get; set; } = null!;

        //public virtual ICollection<StockList> StockLists { get; set; } = new List<StockList>();
    }
}
