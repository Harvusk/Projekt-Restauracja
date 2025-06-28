using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Projekt_Restauracja.Models;

namespace Projekt_Restauracja.Forms
{
    public partial class AnalyticsForm : Form
    {
        private readonly IAnalyticsService _analyticsService;

        public AnalyticsForm(IAnalyticsService analyticsService)
        {
            InitializeComponent();
            _analyticsService = analyticsService;

            cmbAnalyticsType.SelectedIndex = 0;
            LoadSelectedAnalytics();
        }

        private void cmbAnalyticsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSelectedAnalytics();
        }

        private void LoadSelectedAnalytics()
        {
            string selected = cmbAnalyticsType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected)) return;

            switch (selected)
            {
                case "Największe Obłożenie":
                    LoadTableOccupancyAnalytics();
                    break;
                case "Najpopularniejsze dania":
                    LoadPopularMenuItemsAnalytics();
                    break;
                case "Utarg":
                    LoadRevenueAnalytics();
                    break;
            }
        }

        private void LoadTableOccupancyAnalytics()
        {
            var fromDate = DateTime.Now.Date.AddDays(-30);
            var data = _analyticsService.GetTableOccupancyData(fromDate);
            int N = 30;
            var filtered = data.Skip(Math.Max(0, data.Count - N)).ToList();

            SetupLineChart(
                "Największe Obłożenie (Ostatnie 30 dni)", "Data i godzina", "Liczba rezerwacji",
                filtered.Select(x => $"{x.Date:dd.MM} {x.Time}").ToArray(),
                filtered.Select(x => (double)x.Count).ToArray()
            );
        }

        private void LoadPopularMenuItemsAnalytics()
        {
            var fromDate = DateTime.Now.Date.AddDays(-30);
            var data = _analyticsService.GetPopularMenuItemsData(fromDate)
                .OrderByDescending(x => x.Count)
                .Take(10)
                .ToList();

            SetupBarChart(
                "Najpopularniejsze dania (Ostatnie 30 dni)", "Danie", "Liczba zamówień",
                data.Select(x => x.ItemName).ToArray(),
                data.Select(x => (double)x.Count).ToArray()
            );
        }

        private void LoadRevenueAnalytics()
        {
            var fromDate = DateTime.Now.Date.AddDays(-30);
            var data = _analyticsService.GetRevenueData(fromDate);

            int N = 20;
            var filtered = data.Skip(Math.Max(0, data.Count - N)).ToList();

            SetupBarChart(
                "Utarg (Ostatnie 30 dni)", "Data", "Utarg",
                filtered.Select(x => x.Date.ToShortDateString()).ToArray(),
                filtered.Select(x => (double)x.TotalRevenue).ToArray()

            );
        }

        // --- CHART SETUP METHODS ---

        private void SetupLineChart(string title, string xAxisTitle, string yAxisTitle, string[] xValues, double[] yValues)
        {
            chartAnalytics.Series.Clear();
            chartAnalytics.Titles.Clear();
            chartAnalytics.Titles.Add(title);
            chartAnalytics.Titles[0].ForeColor = System.Drawing.Color.White;

            var area = chartAnalytics.ChartAreas[0];
            area.AxisX.Title = xAxisTitle;
            area.AxisX.TitleForeColor = System.Drawing.Color.White;
            area.AxisY.Title = yAxisTitle;
            area.AxisY.TitleForeColor = System.Drawing.Color.White;

            // Line chart, Italian green
            var series = new Series
            {
                Name = "AnalyticsData",
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = System.Drawing.Color.FromArgb(0, 158, 96),
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 7,
                MarkerColor = System.Drawing.Color.White,
                IsValueShownAsLabel = false
            };

            for (int i = 0; i < xValues.Length; i++)
            {
                int pointIdx = series.Points.AddXY(xValues[i], yValues[i]);
                series.Points[pointIdx].IsValueShownAsLabel = (i % 5 == 0);
                series.Points[pointIdx].LabelForeColor = System.Drawing.Color.White;
            }
            series.ToolTip = "#VALX: #VALY";

            chartAnalytics.Series.Add(series);

            // X axis
            var xAxis = area.AxisX;
            xAxis.LabelStyle.Angle = -30;
            xAxis.LabelStyle.Interval = 3;
            xAxis.LabelStyle.ForeColor = System.Drawing.Color.White;
            xAxis.MajorGrid.LineColor = System.Drawing.Color.FromArgb(50, 50, 50);

            // Y axis
            var yAxis = area.AxisY;
            yAxis.LabelStyle.ForeColor = System.Drawing.Color.White;
            yAxis.MajorGrid.LineColor = System.Drawing.Color.FromArgb(60, 60, 60);
        }

        private void SetupBarChart(string title, string xAxisTitle, string yAxisTitle, string[] xValues, double[] yValues)
        {
            chartAnalytics.Series.Clear();
            chartAnalytics.Titles.Clear();
            chartAnalytics.Titles.Add(title);
            chartAnalytics.Titles[0].ForeColor = System.Drawing.Color.White;

            var area = chartAnalytics.ChartAreas[0];
            area.AxisX.Title = xAxisTitle;
            area.AxisX.TitleForeColor = System.Drawing.Color.White;
            area.AxisY.Title = yAxisTitle;
            area.AxisY.TitleForeColor = System.Drawing.Color.White;

            var series = new Series
            {
                Name = "AnalyticsData",
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.FromArgb(0, 158, 96),
                IsValueShownAsLabel = true,
                LabelForeColor = System.Drawing.Color.White
            };

            for (int i = 0; i < xValues.Length; i++)
            {
                int pointIdx = series.Points.AddXY(xValues[i], yValues[i]);
                series.Points[pointIdx].IsValueShownAsLabel = (xValues.Length <= 15) || (i % 2 == 0);
                series.Points[pointIdx].LabelForeColor = System.Drawing.Color.White;
            }
            series.ToolTip = "#VALX: #VALY";

            chartAnalytics.Series.Add(series);

            // X axis
            var xAxis = area.AxisX;
            xAxis.LabelStyle.Angle = -15;
            xAxis.LabelStyle.Interval = (xValues.Length > 15) ? 2 : 1;
            xAxis.LabelStyle.ForeColor = System.Drawing.Color.White;
            xAxis.MajorGrid.Enabled = false;

            // Y axis
            var yAxis = area.AxisY;
            yAxis.LabelStyle.ForeColor = System.Drawing.Color.White;
            yAxis.MajorGrid.LineColor = System.Drawing.Color.FromArgb(60, 60, 60);
        }
    }
}
