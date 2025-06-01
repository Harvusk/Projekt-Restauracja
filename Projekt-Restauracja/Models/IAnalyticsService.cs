using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Restauracja.Forms
{
    public interface IAnalyticsService
    {
        List<TableOccupancyData> GetTableOccupancyData(DateTime fromDate);
        List<PopularMenuItemData> GetPopularMenuItemsData(DateTime fromDate);
        List<RevenueData> GetRevenueData(DateTime fromDate);
    }
}
