﻿using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IProductCostHistoryService
    {
        List<ProductCostHistory> GetAllProductCostHistories();
        List<ProductCostHistory> GetProductCostHistoriesByProductId(int productId);
        void UpdateProductCostHistory(ProductCostHistory productCostHistory);
        void DeleteProductCostHistory(ProductCostHistory productCostHistory);
        void CreateProductCostHistory(ProductCostHistory productCostHistory);
    }
}
