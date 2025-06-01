using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_Restauracja.Models;

namespace Projekt_Restauracja.Forms
{
    public class AnalyticsService : IAnalyticsService
    {
        private readonly RestaurantContext _dbContext;

        public AnalyticsService(RestaurantContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TableOccupancyData> GetTableOccupancyData(DateTime fromDate)
        {
            return _dbContext.Reservations
                .Where(r => r.ReservationDate >= fromDate)
                .AsEnumerable()
                .GroupBy(r => new { Date = r.ReservationDate.Date, Time = r.ReservationTime })
                .Select(g => new TableOccupancyData
                {
                    Date = g.Key.Date,
                    Time = g.Key.Time,
                    Count = g.Count()
                })
                .OrderBy(x => x.Date)
                .ThenBy(x => x.Time)
                .ToList();
        }

        public List<PopularMenuItemData> GetPopularMenuItemsData(DateTime fromDate)
        {
            var orderIds = _dbContext.Orders
                .Where(o => o.CreatedAt >= fromDate)
                .Select(o => o.OrderId)
                .ToList();

            return (from oi in _dbContext.OrderItems
                    join mi in _dbContext.MenuItems on oi.MenuItemId equals mi.MenuItemId
                    where orderIds.Contains(oi.OrderId)
                    group oi by mi.Name into g
                    select new PopularMenuItemData
                    {
                        ItemName = g.Key,
                        Count = g.Sum(x => x.Quantity)
                    })
                .OrderByDescending(x => x.Count)
                .Take(10)
                .ToList();
        }

        public List<RevenueData> GetRevenueData(DateTime fromDate)
        {
            return _dbContext.Orders
                .Where(o => o.OrderDate >= fromDate)
                .GroupBy(o => o.OrderDate.Date)
                .Select(g => new RevenueData
                {
                    Date = g.Key,
                    TotalRevenue = g.Sum(o => o.TotalAmount)
                })
                .OrderBy(x => x.Date)
                .ToList();
        }
    }

    public class TableOccupancyData
    {
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public int Count { get; set; }
    }

    public class PopularMenuItemData
    {
        public string ItemName { get; set; }
        public int Count { get; set; }
    }

    public class RevenueData
    {
        public DateTime Date { get; set; }
        public decimal TotalRevenue { get; set; }
    }
}

