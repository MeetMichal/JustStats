﻿using CsvHelper;
using DeBankUI.Components;
using DeBankUI.Utils;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using MudBlazor.Extensions;
using SkiaSharp;
using System.Globalization;

namespace DeBankUI.Shared.Michal
{
    public partial class LuckyDrawsDailyChart : BaseChartComponent
    {
        private static readonly SKColor black = SKColors.Black;

        public LuckyDrawsDailyChart()
        {
            XAxes = new[]
            {
                new DateTimeAxis(TimeSpan.FromDays(1), date => date.ToString("yyyy-MM-dd"))
                {
                    LabelsRotation = 30,
                    TicksPaint = new SolidColorPaint(black),
                    NamePaint = new SolidColorPaint(black),
                    LabelsPaint = new SolidColorPaint(black),
                }
            };

            YAxes = new[]
            {
                new Axis
                {
                    Name = "Daily number of Lucky Draws",
                    NamePaint = new SolidColorPaint(Colors.SerieBlue),
                    LabelsPaint = new SolidColorPaint(Colors.SerieBlue),
                    TicksPaint = new SolidColorPaint(Colors.SerieBlue),
                    SubticksPaint = new SolidColorPaint(Colors.SerieBlue),
                },
                new Axis
                {
                    Name = "Daily Lucky Draws prizes [$]",
                    ShowSeparatorLines = false,
                    Position = LiveChartsCore.Measure.AxisPosition.End,
                    NamePaint = new SolidColorPaint(Colors.SerieRed),
                    LabelsPaint = new SolidColorPaint(Colors.SerieRed),
                    TicksPaint = new SolidColorPaint(Colors.SerieRed),
                    SubticksPaint = new SolidColorPaint(Colors.SerieRed),
                },
            };

            Series = new[]
            {
                new LineSeries<DateTimePoint>
                {
                    Name="Daily number of Lucky Draws",
                    DataPadding = new LiveChartsCore.Drawing.LvcPoint(0,0),
                    Stroke = new SolidColorPaint(Colors.SerieBlue,4),
                    GeometryStroke = null,
                    GeometrySize = 0,
                    Fill = null,
                    LineSmoothness = 1,
                    ScalesYAt = 0, // it will be scaled at the Axis[0] instance
                    ScalesXAt = 0,
                    Values = new List<DateTimePoint>
                    {
                        new DateTimePoint(new DateTime(2023,7,20),3),
                        new DateTimePoint(new DateTime(2023,7,21),6),
                        new DateTimePoint(new DateTime(2023,7,24),1601),
                        new DateTimePoint(new DateTime(2023,7,25),1106),
                        new DateTimePoint(new DateTime(2023,7,26),1655),
                        new DateTimePoint(new DateTime(2023,7,27),1799),
                        new DateTimePoint(new DateTime(2023,7,28),1351),
                        new DateTimePoint(new DateTime(2023,7,29),655),
                        new DateTimePoint(new DateTime(2023,7,30),598),
                        new DateTimePoint(new DateTime(2023,7,31),722),
                        new DateTimePoint(new DateTime(2023,8,1),730),
                        new DateTimePoint(new DateTime(2023,8,2),800),
                        new DateTimePoint(new DateTime(2023,8,3),692),
                        new DateTimePoint(new DateTime(2023,8,4),645),
                        new DateTimePoint(new DateTime(2023,8,5),617),
                        new DateTimePoint(new DateTime(2023,8,6),611),
                        new DateTimePoint(new DateTime(2023,8,7),607),
                        new DateTimePoint(new DateTime(2023,8,8),457),
                        new DateTimePoint(new DateTime(2023,8,9),350),
                        new DateTimePoint(new DateTime(2023,8,10),321),
                        new DateTimePoint(new DateTime(2023,8,11),521),
                        new DateTimePoint(new DateTime(2023,8,12),485),
                        new DateTimePoint(new DateTime(2023,8,13),523),
                        new DateTimePoint(new DateTime(2023,8,14),530),
                        new DateTimePoint(new DateTime(2023,8,15),575),
                        new DateTimePoint(new DateTime(2023,8,16),563),
                        new DateTimePoint(new DateTime(2023,8,17),470),
                        new DateTimePoint(new DateTime(2023,8,18),540),
                        new DateTimePoint(new DateTime(2023,8,19),645),
                        new DateTimePoint(new DateTime(2023,8,20),617),
                        new DateTimePoint(new DateTime(2023,8,21),618),
                        new DateTimePoint(new DateTime(2023,8,22),499),
                        new DateTimePoint(new DateTime(2023,8,23),460),
                        new DateTimePoint(new DateTime(2023,8,24),512),
                        new DateTimePoint(new DateTime(2023,8,25),399),
                        new DateTimePoint(new DateTime(2023,8,26),397),
                        new DateTimePoint(new DateTime(2023,8,27),364),
                        new DateTimePoint(new DateTime(2023,8,28),398),
                        new DateTimePoint(new DateTime(2023,8,29),379),
                        new DateTimePoint(new DateTime(2023,8,30),338),
                        new DateTimePoint(new DateTime(2023,8,31),356),
                        new DateTimePoint(new DateTime(2023,9,1),314),
                        new DateTimePoint(new DateTime(2023,9,2),284),
                        new DateTimePoint(new DateTime(2023,9,3),284),
                        new DateTimePoint(new DateTime(2023,9,4),296),
                        new DateTimePoint(new DateTime(2023,9,5),269),
                        new DateTimePoint(new DateTime(2023,9,6),280),
                        new DateTimePoint(new DateTime(2023,9,7),342),
                        new DateTimePoint(new DateTime(2023,9,8),285),
                        new DateTimePoint(new DateTime(2023,9,9),220),
                        new DateTimePoint(new DateTime(2023,9,10),230),
                        new DateTimePoint(new DateTime(2023,9,11),240),
                        new DateTimePoint(new DateTime(2023,9,12),233),
                        new DateTimePoint(new DateTime(2023,9,13),216),
                        new DateTimePoint(new DateTime(2023,9,14),211),
                        new DateTimePoint(new DateTime(2023,9,15),611),
                        new DateTimePoint(new DateTime(2023,9,16),509),
                        new DateTimePoint(new DateTime(2023,9,17),479),
                        new DateTimePoint(new DateTime(2023,9,18),542),
                        new DateTimePoint(new DateTime(2023,9,19),475),
                        new DateTimePoint(new DateTime(2023,9,20),393),
                        new DateTimePoint(new DateTime(2023,9,21),316),
                        new DateTimePoint(new DateTime(2023,9,22),323),
                        new DateTimePoint(new DateTime(2023,9,23),307),
                        new DateTimePoint(new DateTime(2023,9,24),257),
                        new DateTimePoint(new DateTime(2023,9,25),327),
                        new DateTimePoint(new DateTime(2023,9,26),311),
                        new DateTimePoint(new DateTime(2023,9,27),308),
                        new DateTimePoint(new DateTime(2023,9,28),304),
                        new DateTimePoint(new DateTime(2023,9,29),268),
                        new DateTimePoint(new DateTime(2023,9,30),286),
                        new DateTimePoint(new DateTime(2023,10,1),282),
                        new DateTimePoint(new DateTime(2023,10,2),332),
                        new DateTimePoint(new DateTime(2023,10,3),262),
                        new DateTimePoint(new DateTime(2023,10,4),283),
                        new DateTimePoint(new DateTime(2023,10,5),259),
                        new DateTimePoint(new DateTime(2023,10,6),248),
                        new DateTimePoint(new DateTime(2023,10,7),254),
                        new DateTimePoint(new DateTime(2023,10,8),242),
                        new DateTimePoint(new DateTime(2023,10,9),235),
                        new DateTimePoint(new DateTime(2023,10,10),255),
                        new DateTimePoint(new DateTime(2023,10,11),331),
                        new DateTimePoint(new DateTime(2023,10,12),319),
                        new DateTimePoint(new DateTime(2023,10,13),469),
                        new DateTimePoint(new DateTime(2023,10,14),418),
                        new DateTimePoint(new DateTime(2023,10,15),371),
                        new DateTimePoint(new DateTime(2023,10,16),425),
                        new DateTimePoint(new DateTime(2023,10,17),357),
                        new DateTimePoint(new DateTime(2023,10,18),314),
                        new DateTimePoint(new DateTime(2023,10,19),307),
                        new DateTimePoint(new DateTime(2023,10,20),520),
                        new DateTimePoint(new DateTime(2023,10,21),541),
                        new DateTimePoint(new DateTime(2023,10,22),528),
                        new DateTimePoint(new DateTime(2023,10,23),475),
                        new DateTimePoint(new DateTime(2023,10,24),478),
                        new DateTimePoint(new DateTime(2023,10,25),431),
                        new DateTimePoint(new DateTime(2023,10,26),427),
                        new DateTimePoint(new DateTime(2023,10,27),410),
                        new DateTimePoint(new DateTime(2023,10,28),470),
                        new DateTimePoint(new DateTime(2023,10,29),395),
                        new DateTimePoint(new DateTime(2023,10,30),457),
                        new DateTimePoint(new DateTime(2023,10,31),406),
                        new DateTimePoint(new DateTime(2023,11,1),396),
                        new DateTimePoint(new DateTime(2023,11,2),368),
                        new DateTimePoint(new DateTime(2023,11,3),452),
                        new DateTimePoint(new DateTime(2023,11,4),402),
                        new DateTimePoint(new DateTime(2023,11,5),441),
                        new DateTimePoint(new DateTime(2023,11,6),461),
                        new DateTimePoint(new DateTime(2023,11,7),445),
                        new DateTimePoint(new DateTime(2023,11,8),392),
                        new DateTimePoint(new DateTime(2023,11,9),400),
                        new DateTimePoint(new DateTime(2023,11,10),480),
                        new DateTimePoint(new DateTime(2023,11,11),463),
                    }
                },
                new LineSeries<DateTimePoint>
                {
                    Name = "Daily Lucky Draws prizes [$]",
                    DataPadding = new LiveChartsCore.Drawing.LvcPoint(0,0),
                    Fill = null,
                    Stroke = new SolidColorPaint(Colors.SerieRed,4),
                    GeometryStroke = null,
                    GeometrySize = 0,
                    LineSmoothness = 1,
                    ScalesXAt = 0,
                    ScalesYAt = 1, // it will be scaled at the Axis[0] instance 
                    Values = new List<DateTimePoint>
                    {
                        new DateTimePoint(new DateTime(2023,7,20),0),
                        new DateTimePoint(new DateTime(2023,7,21),0),
                        new DateTimePoint(new DateTime(2023,7,24),14438),
                        new DateTimePoint(new DateTime(2023,7,25),12184),
                        new DateTimePoint(new DateTime(2023,7,26),10864),
                        new DateTimePoint(new DateTime(2023,7,27),11773),
                        new DateTimePoint(new DateTime(2023,7,28),7857),
                        new DateTimePoint(new DateTime(2023,7,29),3452),
                        new DateTimePoint(new DateTime(2023,7,30),2910),
                        new DateTimePoint(new DateTime(2023,7,31),3199),
                        new DateTimePoint(new DateTime(2023,8,1),4664),
                        new DateTimePoint(new DateTime(2023,8,2),4289),
                        new DateTimePoint(new DateTime(2023,8,3),3124),
                        new DateTimePoint(new DateTime(2023,8,4),2952),
                        new DateTimePoint(new DateTime(2023,8,5),3482),
                        new DateTimePoint(new DateTime(2023,8,6),3344),
                        new DateTimePoint(new DateTime(2023,8,7),2853),
                        new DateTimePoint(new DateTime(2023,8,8),2252),
                        new DateTimePoint(new DateTime(2023,8,9),2477),
                        new DateTimePoint(new DateTime(2023,8,10),1826),
                        new DateTimePoint(new DateTime(2023,8,11),3346),
                        new DateTimePoint(new DateTime(2023,8,12),2267),
                        new DateTimePoint(new DateTime(2023,8,13),2892),
                        new DateTimePoint(new DateTime(2023,8,14),2999),
                        new DateTimePoint(new DateTime(2023,8,15),2995),
                        new DateTimePoint(new DateTime(2023,8,16),2240),
                        new DateTimePoint(new DateTime(2023,8,17),2531),
                        new DateTimePoint(new DateTime(2023,8,18),2300),
                        new DateTimePoint(new DateTime(2023,8,19),3090),
                        new DateTimePoint(new DateTime(2023,8,20),2698),
                        new DateTimePoint(new DateTime(2023,8,21),2935),
                        new DateTimePoint(new DateTime(2023,8,22),3061),
                        new DateTimePoint(new DateTime(2023,8,23),2606),
                        new DateTimePoint(new DateTime(2023,8,24),3386),
                        new DateTimePoint(new DateTime(2023,8,25),2264),
                        new DateTimePoint(new DateTime(2023,8,26),2446),
                        new DateTimePoint(new DateTime(2023,8,27),1408),
                        new DateTimePoint(new DateTime(2023,8,28),2086),
                        new DateTimePoint(new DateTime(2023,8,29),2140),
                        new DateTimePoint(new DateTime(2023,8,30),1577),
                        new DateTimePoint(new DateTime(2023,8,31),1974),
                        new DateTimePoint(new DateTime(2023,9,1),2987),
                        new DateTimePoint(new DateTime(2023,9,2),2254),
                        new DateTimePoint(new DateTime(2023,9,3),1581),
                        new DateTimePoint(new DateTime(2023,9,4),1291),
                        new DateTimePoint(new DateTime(2023,9,5),1623),
                        new DateTimePoint(new DateTime(2023,9,6),1670),
                        new DateTimePoint(new DateTime(2023,9,7),2801),
                        new DateTimePoint(new DateTime(2023,9,8),1860),
                        new DateTimePoint(new DateTime(2023,9,9),865),
                        new DateTimePoint(new DateTime(2023,9,10),1245),
                        new DateTimePoint(new DateTime(2023,9,11),1273),
                        new DateTimePoint(new DateTime(2023,9,12),1621),
                        new DateTimePoint(new DateTime(2023,9,13),1216),
                        new DateTimePoint(new DateTime(2023,9,14),1601),
                        new DateTimePoint(new DateTime(2023,9,15),3919),
                        new DateTimePoint(new DateTime(2023,9,16),2469),
                        new DateTimePoint(new DateTime(2023,9,17),2439),
                        new DateTimePoint(new DateTime(2023,9,18),3178),
                        new DateTimePoint(new DateTime(2023,9,19),2235),
                        new DateTimePoint(new DateTime(2023,9,20),1912),
                        new DateTimePoint(new DateTime(2023,9,21),1863),
                        new DateTimePoint(new DateTime(2023,9,22),1315),
                        new DateTimePoint(new DateTime(2023,9,23),1440),
                        new DateTimePoint(new DateTime(2023,9,24),1310),
                        new DateTimePoint(new DateTime(2023,9,25),1827),
                        new DateTimePoint(new DateTime(2023,9,26),1784),
                        new DateTimePoint(new DateTime(2023,9,27),1625),
                        new DateTimePoint(new DateTime(2023,9,28),2037),
                        new DateTimePoint(new DateTime(2023,9,29),1510),
                        new DateTimePoint(new DateTime(2023,9,30),2214),
                        new DateTimePoint(new DateTime(2023,10,1),3692),
                        new DateTimePoint(new DateTime(2023,10,2),2181),
                        new DateTimePoint(new DateTime(2023,10,3),1088),
                        new DateTimePoint(new DateTime(2023,10,4),1035),
                        new DateTimePoint(new DateTime(2023,10,5),1094),
                        new DateTimePoint(new DateTime(2023,10,6),1842),
                        new DateTimePoint(new DateTime(2023,10,7),1186),
                        new DateTimePoint(new DateTime(2023,10,8),1575),
                        new DateTimePoint(new DateTime(2023,10,9),1151),
                        new DateTimePoint(new DateTime(2023,10,10),965),
                        new DateTimePoint(new DateTime(2023,10,11),1240),
                        new DateTimePoint(new DateTime(2023,10,12),1757),
                        new DateTimePoint(new DateTime(2023,10,13),1400),
                        new DateTimePoint(new DateTime(2023,10,14),1802),
                        new DateTimePoint(new DateTime(2023,10,15),1239),
                        new DateTimePoint(new DateTime(2023,10,16),1606),
                        new DateTimePoint(new DateTime(2023,10,17),1315),
                        new DateTimePoint(new DateTime(2023,10,18),1349),
                        new DateTimePoint(new DateTime(2023,10,19),1151),
                        new DateTimePoint(new DateTime(2023,10,20),1238),
                        new DateTimePoint(new DateTime(2023,10,21),1189),
                        new DateTimePoint(new DateTime(2023,10,22),1317),
                        new DateTimePoint(new DateTime(2023,10,23),1315),
                        new DateTimePoint(new DateTime(2023,10,24),1451),
                        new DateTimePoint(new DateTime(2023,10,25),1175),
                        new DateTimePoint(new DateTime(2023,10,26),1282),
                        new DateTimePoint(new DateTime(2023,10,27),1108),
                        new DateTimePoint(new DateTime(2023,10,28),1389),
                        new DateTimePoint(new DateTime(2023,10,29),1151),
                        new DateTimePoint(new DateTime(2023,10,30),1356),
                        new DateTimePoint(new DateTime(2023,10,31),1683),
                        new DateTimePoint(new DateTime(2023,11,1),1860),
                        new DateTimePoint(new DateTime(2023,11,2),1198),
                        new DateTimePoint(new DateTime(2023,11,3),1344),
                        new DateTimePoint(new DateTime(2023,11,4),1402),
                        new DateTimePoint(new DateTime(2023,11,5),1492),
                        new DateTimePoint(new DateTime(2023,11,6),1545),
                        new DateTimePoint(new DateTime(2023,11,7),1425),
                        new DateTimePoint(new DateTime(2023,11,8),1358),
                        new DateTimePoint(new DateTime(2023,11,9),1315),
                        new DateTimePoint(new DateTime(2023,11,10),2368),
                        new DateTimePoint(new DateTime(2023,11,11),1698),
                    }
                }
            };
        }

        public override byte[] DownloadChartData()
        {
            var dailySerie = Series[0].As<LineSeries<DateTimePoint>>();
            var prizeSerie = Series[1].As<LineSeries<DateTimePoint>>();

            var dailySerieValues = dailySerie.Values.ToList();
            var prizeSerieValues = prizeSerie.Values.ToList();
            var records = new List<CsvData>();

            for (int i = 0; i < dailySerie.Values.Count(); i++)
            {
                records.Add(new CsvData 
                { 
                    Date = dailySerieValues[i].DateTime,
                    DailyDraws = dailySerieValues[i].Value,
                    DailyPrizes = prizeSerieValues[i].Value,
                });
            }

            using (var stream = new MemoryStream())
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
                writer.Flush();
                return stream.ToArray();
            }
        }

        private class CsvData
        {
            public DateTime Date { get; set; }
            public double? DailyPrizes { get; set; }
            public double? DailyDraws { get; set; }
        }
    }
}
