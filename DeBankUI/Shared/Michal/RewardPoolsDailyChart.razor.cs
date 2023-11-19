﻿using CsvHelper;
using DeBankUI.Components;
using DeBankUI.Utils;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using MudBlazor.Extensions;
using SkiaSharp;
using System.Globalization;

namespace DeBankUI.Shared.Michal
{
    public partial class RewardPoolsDailyChart : BaseChartComponent
    {
        private static readonly SKColor black = SKColors.Black;

        public RewardPoolsDailyChart()
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
                    Name = "Daily number of Reward Pools",
                    NamePaint = new SolidColorPaint(Colors.SerieBlue),
                    LabelsPaint = new SolidColorPaint(Colors.SerieBlue),
                    TicksPaint = new SolidColorPaint(Colors.SerieBlue),
                    SubticksPaint = new SolidColorPaint(Colors.SerieBlue),
                },
                new Axis
                {
                    Name = "Daily Reward Pools prizes [$]",
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
                    Name="Daily number of Reward Pools",
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
                         new DateTimePoint(new DateTime(2023,6,9),1),
                        new DateTimePoint(new DateTime(2023,6,11),13),
                        new DateTimePoint(new DateTime(2023,6,12),125),
                        new DateTimePoint(new DateTime(2023,6,13),91),
                        new DateTimePoint(new DateTime(2023,6,14),212),
                        new DateTimePoint(new DateTime(2023,6,15),230),
                        new DateTimePoint(new DateTime(2023,6,16),257),
                        new DateTimePoint(new DateTime(2023,6,17),148),
                        new DateTimePoint(new DateTime(2023,6,18),94),
                        new DateTimePoint(new DateTime(2023,6,19),112),
                        new DateTimePoint(new DateTime(2023,6,20),174),
                        new DateTimePoint(new DateTime(2023,6,21),169),
                        new DateTimePoint(new DateTime(2023,6,22),270),
                        new DateTimePoint(new DateTime(2023,6,23),168),
                        new DateTimePoint(new DateTime(2023,6,24),90),
                        new DateTimePoint(new DateTime(2023,6,25),91),
                        new DateTimePoint(new DateTime(2023,6,26),142),
                        new DateTimePoint(new DateTime(2023,6,27),422),
                        new DateTimePoint(new DateTime(2023,6,28),116),
                        new DateTimePoint(new DateTime(2023,6,29),134),
                        new DateTimePoint(new DateTime(2023,6,30),163),
                        new DateTimePoint(new DateTime(2023,7,1),272),
                        new DateTimePoint(new DateTime(2023,7,2),181),
                        new DateTimePoint(new DateTime(2023,7,3),205),
                        new DateTimePoint(new DateTime(2023,7,4),391),
                        new DateTimePoint(new DateTime(2023,7,5),411),
                        new DateTimePoint(new DateTime(2023,7,6),366),
                        new DateTimePoint(new DateTime(2023,7,7),171),
                        new DateTimePoint(new DateTime(2023,7,8),134),
                        new DateTimePoint(new DateTime(2023,7,9),139),
                        new DateTimePoint(new DateTime(2023,7,10),191),
                        new DateTimePoint(new DateTime(2023,7,11),222),
                        new DateTimePoint(new DateTime(2023,7,12),205),
                        new DateTimePoint(new DateTime(2023,7,13),264),
                        new DateTimePoint(new DateTime(2023,7,14),449),
                        new DateTimePoint(new DateTime(2023,7,15),293),
                        new DateTimePoint(new DateTime(2023,7,16),277),
                        new DateTimePoint(new DateTime(2023,7,17),315),
                        new DateTimePoint(new DateTime(2023,7,18),297),
                        new DateTimePoint(new DateTime(2023,7,19),446),
                        new DateTimePoint(new DateTime(2023,7,20),614),
                        new DateTimePoint(new DateTime(2023,7,21),638),
                        new DateTimePoint(new DateTime(2023,7,22),701),
                        new DateTimePoint(new DateTime(2023,7,23),810),
                        new DateTimePoint(new DateTime(2023,7,24),1305),
                        new DateTimePoint(new DateTime(2023,7,25),1194),
                        new DateTimePoint(new DateTime(2023,7,26),1383),
                        new DateTimePoint(new DateTime(2023,7,27),1422),
                        new DateTimePoint(new DateTime(2023,7,28),1334),
                        new DateTimePoint(new DateTime(2023,7,29),976),
                        new DateTimePoint(new DateTime(2023,7,30),960),
                        new DateTimePoint(new DateTime(2023,7,31),1086),
                        new DateTimePoint(new DateTime(2023,8,1),1144),
                        new DateTimePoint(new DateTime(2023,8,2),1159),
                        new DateTimePoint(new DateTime(2023,8,3),1075),
                        new DateTimePoint(new DateTime(2023,8,4),1220),
                        new DateTimePoint(new DateTime(2023,8,5),957),
                        new DateTimePoint(new DateTime(2023,8,6),900),
                        new DateTimePoint(new DateTime(2023,8,7),1232),
                        new DateTimePoint(new DateTime(2023,8,8),1301),
                        new DateTimePoint(new DateTime(2023,8,9),1270),
                        new DateTimePoint(new DateTime(2023,8,10),1076),
                        new DateTimePoint(new DateTime(2023,8,11),1191),
                        new DateTimePoint(new DateTime(2023,8,12),913),
                        new DateTimePoint(new DateTime(2023,8,13),769),
                        new DateTimePoint(new DateTime(2023,8,14),996),
                        new DateTimePoint(new DateTime(2023,8,15),918),
                        new DateTimePoint(new DateTime(2023,8,16),812),
                        new DateTimePoint(new DateTime(2023,8,17),802),
                        new DateTimePoint(new DateTime(2023,8,18),709),
                        new DateTimePoint(new DateTime(2023,8,19),745),
                        new DateTimePoint(new DateTime(2023,8,20),755),
                        new DateTimePoint(new DateTime(2023,8,21),779),
                        new DateTimePoint(new DateTime(2023,8,22),756),
                        new DateTimePoint(new DateTime(2023,8,23),659),
                        new DateTimePoint(new DateTime(2023,8,24),701),
                        new DateTimePoint(new DateTime(2023,8,25),625),
                        new DateTimePoint(new DateTime(2023,8,26),593),
                        new DateTimePoint(new DateTime(2023,8,27),547),
                        new DateTimePoint(new DateTime(2023,8,28),633),
                        new DateTimePoint(new DateTime(2023,8,29),647),
                        new DateTimePoint(new DateTime(2023,8,30),577),
                        new DateTimePoint(new DateTime(2023,8,31),569),
                        new DateTimePoint(new DateTime(2023,9,1),537),
                        new DateTimePoint(new DateTime(2023,9,2),505),
                        new DateTimePoint(new DateTime(2023,9,3),505),
                        new DateTimePoint(new DateTime(2023,9,4),556),
                        new DateTimePoint(new DateTime(2023,9,5),578),
                        new DateTimePoint(new DateTime(2023,9,6),529),
                        new DateTimePoint(new DateTime(2023,9,7),613),
                        new DateTimePoint(new DateTime(2023,9,8),496),
                        new DateTimePoint(new DateTime(2023,9,9),401),
                        new DateTimePoint(new DateTime(2023,9,10),426),
                        new DateTimePoint(new DateTime(2023,9,11),496),
                        new DateTimePoint(new DateTime(2023,9,12),456),
                        new DateTimePoint(new DateTime(2023,9,13),497),
                        new DateTimePoint(new DateTime(2023,9,14),573),
                        new DateTimePoint(new DateTime(2023,9,15),933),
                        new DateTimePoint(new DateTime(2023,9,16),648),
                        new DateTimePoint(new DateTime(2023,9,17),589),
                        new DateTimePoint(new DateTime(2023,9,18),809),
                        new DateTimePoint(new DateTime(2023,9,19),777),
                        new DateTimePoint(new DateTime(2023,9,20),711),
                        new DateTimePoint(new DateTime(2023,9,21),596),
                        new DateTimePoint(new DateTime(2023,9,22),697),
                        new DateTimePoint(new DateTime(2023,9,23),626),
                        new DateTimePoint(new DateTime(2023,9,24),526),
                        new DateTimePoint(new DateTime(2023,9,25),624),
                        new DateTimePoint(new DateTime(2023,9,26),669),
                        new DateTimePoint(new DateTime(2023,9,27),817),
                        new DateTimePoint(new DateTime(2023,9,28),715),
                        new DateTimePoint(new DateTime(2023,9,29),801),
                        new DateTimePoint(new DateTime(2023,9,30),710),
                        new DateTimePoint(new DateTime(2023,10,1),761),
                        new DateTimePoint(new DateTime(2023,10,2),850),
                        new DateTimePoint(new DateTime(2023,10,3),796),
                        new DateTimePoint(new DateTime(2023,10,4),842),
                        new DateTimePoint(new DateTime(2023,10,5),778),
                        new DateTimePoint(new DateTime(2023,10,6),820),
                        new DateTimePoint(new DateTime(2023,10,7),748),
                        new DateTimePoint(new DateTime(2023,10,8),631),
                        new DateTimePoint(new DateTime(2023,10,9),784),
                        new DateTimePoint(new DateTime(2023,10,10),893),
                        new DateTimePoint(new DateTime(2023,10,11),984),
                        new DateTimePoint(new DateTime(2023,10,12),1077),
                        new DateTimePoint(new DateTime(2023,10,13),1064),
                        new DateTimePoint(new DateTime(2023,10,14),1008),
                        new DateTimePoint(new DateTime(2023,10,15),1496),
                        new DateTimePoint(new DateTime(2023,10,16),1235),
                        new DateTimePoint(new DateTime(2023,10,17),1021),
                        new DateTimePoint(new DateTime(2023,10,18),1072),
                        new DateTimePoint(new DateTime(2023,10,19),965),
                        new DateTimePoint(new DateTime(2023,10,20),1140),
                        new DateTimePoint(new DateTime(2023,10,21),1113),
                        new DateTimePoint(new DateTime(2023,10,22),1091),
                        new DateTimePoint(new DateTime(2023,10,23),1274),
                        new DateTimePoint(new DateTime(2023,10,24),1239),
                        new DateTimePoint(new DateTime(2023,10,25),1307),
                        new DateTimePoint(new DateTime(2023,10,26),1068),
                        new DateTimePoint(new DateTime(2023,10,27),1100),
                        new DateTimePoint(new DateTime(2023,10,28),1107),
                        new DateTimePoint(new DateTime(2023,10,29),1000),
                        new DateTimePoint(new DateTime(2023,10,30),1225),
                        new DateTimePoint(new DateTime(2023,10,31),1181),
                        new DateTimePoint(new DateTime(2023,11,1),1073),
                        new DateTimePoint(new DateTime(2023,11,2),1136),
                        new DateTimePoint(new DateTime(2023,11,3),1309),
                        new DateTimePoint(new DateTime(2023,11,4),1300),
                        new DateTimePoint(new DateTime(2023,11,5),1218),
                        new DateTimePoint(new DateTime(2023,11,6),1425),
                        new DateTimePoint(new DateTime(2023,11,7),1316),
                        new DateTimePoint(new DateTime(2023,11,8),1357),
                        new DateTimePoint(new DateTime(2023,11,9),1447),
                        new DateTimePoint(new DateTime(2023,11,10),1433),
                        new DateTimePoint(new DateTime(2023,11,11),1182),
                    }
                },
                new LineSeries<DateTimePoint>
                {
                    Name = "Daily Reward Pools prizes [$]",
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
                        new DateTimePoint(new DateTime(2023,6,9),0),
                        new DateTimePoint(new DateTime(2023,6,11),2),
                        new DateTimePoint(new DateTime(2023,6,12),148),
                        new DateTimePoint(new DateTime(2023,6,13),541),
                        new DateTimePoint(new DateTime(2023,6,14),762),
                        new DateTimePoint(new DateTime(2023,6,15),188),
                        new DateTimePoint(new DateTime(2023,6,16),459),
                        new DateTimePoint(new DateTime(2023,6,17),271),
                        new DateTimePoint(new DateTime(2023,6,18),197),
                        new DateTimePoint(new DateTime(2023,6,19),346),
                        new DateTimePoint(new DateTime(2023,6,20),546),
                        new DateTimePoint(new DateTime(2023,6,21),384),
                        new DateTimePoint(new DateTime(2023,6,22),443),
                        new DateTimePoint(new DateTime(2023,6,23),157),
                        new DateTimePoint(new DateTime(2023,6,24),114),
                        new DateTimePoint(new DateTime(2023,6,25),74),
                        new DateTimePoint(new DateTime(2023,6,26),315),
                        new DateTimePoint(new DateTime(2023,6,27),207),
                        new DateTimePoint(new DateTime(2023,6,28),69),
                        new DateTimePoint(new DateTime(2023,6,29),78),
                        new DateTimePoint(new DateTime(2023,6,30),560),
                        new DateTimePoint(new DateTime(2023,7,1),674),
                        new DateTimePoint(new DateTime(2023,7,2),331),
                        new DateTimePoint(new DateTime(2023,7,3),490),
                        new DateTimePoint(new DateTime(2023,7,4),200),
                        new DateTimePoint(new DateTime(2023,7,5),378),
                        new DateTimePoint(new DateTime(2023,7,6),381),
                        new DateTimePoint(new DateTime(2023,7,7),1328),
                        new DateTimePoint(new DateTime(2023,7,8),402),
                        new DateTimePoint(new DateTime(2023,7,9),318),
                        new DateTimePoint(new DateTime(2023,7,10),532),
                        new DateTimePoint(new DateTime(2023,7,11),381),
                        new DateTimePoint(new DateTime(2023,7,12),485),
                        new DateTimePoint(new DateTime(2023,7,13),960),
                        new DateTimePoint(new DateTime(2023,7,14),2213),
                        new DateTimePoint(new DateTime(2023,7,15),1465),
                        new DateTimePoint(new DateTime(2023,7,16),1972),
                        new DateTimePoint(new DateTime(2023,7,17),2307),
                        new DateTimePoint(new DateTime(2023,7,18),1453),
                        new DateTimePoint(new DateTime(2023,7,19),2622),
                        new DateTimePoint(new DateTime(2023,7,20),2024),
                        new DateTimePoint(new DateTime(2023,7,21),2523),
                        new DateTimePoint(new DateTime(2023,7,22),1782),
                        new DateTimePoint(new DateTime(2023,7,23),2980),
                        new DateTimePoint(new DateTime(2023,7,24),4259),
                        new DateTimePoint(new DateTime(2023,7,25),3718),
                        new DateTimePoint(new DateTime(2023,7,26),4595),
                        new DateTimePoint(new DateTime(2023,7,27),7494),
                        new DateTimePoint(new DateTime(2023,7,28),12986),
                        new DateTimePoint(new DateTime(2023,7,29),2860),
                        new DateTimePoint(new DateTime(2023,7,30),3247),
                        new DateTimePoint(new DateTime(2023,7,31),1980),
                        new DateTimePoint(new DateTime(2023,8,1),2486),
                        new DateTimePoint(new DateTime(2023,8,2),4883),
                        new DateTimePoint(new DateTime(2023,8,3),2708),
                        new DateTimePoint(new DateTime(2023,8,4),2598),
                        new DateTimePoint(new DateTime(2023,8,5),1653),
                        new DateTimePoint(new DateTime(2023,8,6),1753),
                        new DateTimePoint(new DateTime(2023,8,7),3142),
                        new DateTimePoint(new DateTime(2023,8,8),2949),
                        new DateTimePoint(new DateTime(2023,8,9),3023),
                        new DateTimePoint(new DateTime(2023,8,10),2002),
                        new DateTimePoint(new DateTime(2023,8,11),2660),
                        new DateTimePoint(new DateTime(2023,8,12),2096),
                        new DateTimePoint(new DateTime(2023,8,13),2239),
                        new DateTimePoint(new DateTime(2023,8,14),4048),
                        new DateTimePoint(new DateTime(2023,8,15),1889),
                        new DateTimePoint(new DateTime(2023,8,16),2618),
                        new DateTimePoint(new DateTime(2023,8,17),2511),
                        new DateTimePoint(new DateTime(2023,8,18),2628),
                        new DateTimePoint(new DateTime(2023,8,19),1861),
                        new DateTimePoint(new DateTime(2023,8,20),2642),
                        new DateTimePoint(new DateTime(2023,8,21),1850),
                        new DateTimePoint(new DateTime(2023,8,22),2542),
                        new DateTimePoint(new DateTime(2023,8,23),2206),
                        new DateTimePoint(new DateTime(2023,8,24),1767),
                        new DateTimePoint(new DateTime(2023,8,25),2093),
                        new DateTimePoint(new DateTime(2023,8,26),1381),
                        new DateTimePoint(new DateTime(2023,8,27),1323),
                        new DateTimePoint(new DateTime(2023,8,28),1919),
                        new DateTimePoint(new DateTime(2023,8,29),1830),
                        new DateTimePoint(new DateTime(2023,8,30),1842),
                        new DateTimePoint(new DateTime(2023,8,31),1647),
                        new DateTimePoint(new DateTime(2023,9,1),2641),
                        new DateTimePoint(new DateTime(2023,9,2),1608),
                        new DateTimePoint(new DateTime(2023,9,3),1266),
                        new DateTimePoint(new DateTime(2023,9,4),1454),
                        new DateTimePoint(new DateTime(2023,9,5),1422),
                        new DateTimePoint(new DateTime(2023,9,6),1585),
                        new DateTimePoint(new DateTime(2023,9,7),2151),
                        new DateTimePoint(new DateTime(2023,9,8),1657),
                        new DateTimePoint(new DateTime(2023,9,9),949),
                        new DateTimePoint(new DateTime(2023,9,10),1064),
                        new DateTimePoint(new DateTime(2023,9,11),1223),
                        new DateTimePoint(new DateTime(2023,9,12),1413),
                        new DateTimePoint(new DateTime(2023,9,13),1244),
                        new DateTimePoint(new DateTime(2023,9,14),2774),
                        new DateTimePoint(new DateTime(2023,9,15),6585),
                        new DateTimePoint(new DateTime(2023,9,16),3305),
                        new DateTimePoint(new DateTime(2023,9,17),2425),
                        new DateTimePoint(new DateTime(2023,9,18),2461),
                        new DateTimePoint(new DateTime(2023,9,19),2085),
                        new DateTimePoint(new DateTime(2023,9,20),2239),
                        new DateTimePoint(new DateTime(2023,9,21),1772),
                        new DateTimePoint(new DateTime(2023,9,22),1856),
                        new DateTimePoint(new DateTime(2023,9,23),4037),
                        new DateTimePoint(new DateTime(2023,9,24),2915),
                        new DateTimePoint(new DateTime(2023,9,25),1758),
                        new DateTimePoint(new DateTime(2023,9,26),1752),
                        new DateTimePoint(new DateTime(2023,9,27),2953),
                        new DateTimePoint(new DateTime(2023,9,28),2393),
                        new DateTimePoint(new DateTime(2023,9,29),3282),
                        new DateTimePoint(new DateTime(2023,9,30),2393),
                        new DateTimePoint(new DateTime(2023,10,1),2859),
                        new DateTimePoint(new DateTime(2023,10,2),3342),
                        new DateTimePoint(new DateTime(2023,10,3),3011),
                        new DateTimePoint(new DateTime(2023,10,4),10471),
                        new DateTimePoint(new DateTime(2023,10,5),4503),
                        new DateTimePoint(new DateTime(2023,10,6),5294),
                        new DateTimePoint(new DateTime(2023,10,7),3547),
                        new DateTimePoint(new DateTime(2023,10,8),4054),
                        new DateTimePoint(new DateTime(2023,10,9),2880),
                        new DateTimePoint(new DateTime(2023,10,10),3272),
                        new DateTimePoint(new DateTime(2023,10,11),2580),
                        new DateTimePoint(new DateTime(2023,10,12),5956),
                        new DateTimePoint(new DateTime(2023,10,13),3874),
                        new DateTimePoint(new DateTime(2023,10,14),2756),
                        new DateTimePoint(new DateTime(2023,10,15),3451),
                        new DateTimePoint(new DateTime(2023,10,16),2552),
                        new DateTimePoint(new DateTime(2023,10,17),2904),
                        new DateTimePoint(new DateTime(2023,10,18),4441),
                        new DateTimePoint(new DateTime(2023,10,19),3445),
                        new DateTimePoint(new DateTime(2023,10,20),4816),
                        new DateTimePoint(new DateTime(2023,10,21),2839),
                        new DateTimePoint(new DateTime(2023,10,22),3034),
                        new DateTimePoint(new DateTime(2023,10,23),3459),
                        new DateTimePoint(new DateTime(2023,10,24),4110),
                        new DateTimePoint(new DateTime(2023,10,25),7376),
                        new DateTimePoint(new DateTime(2023,10,26),3005),
                        new DateTimePoint(new DateTime(2023,10,27),3183),
                        new DateTimePoint(new DateTime(2023,10,28),2794),
                        new DateTimePoint(new DateTime(2023,10,29),2660),
                        new DateTimePoint(new DateTime(2023,10,30),2778),
                        new DateTimePoint(new DateTime(2023,10,31),4507),
                        new DateTimePoint(new DateTime(2023,11,1),2640),
                        new DateTimePoint(new DateTime(2023,11,2),6128),
                        new DateTimePoint(new DateTime(2023,11,3),4050),
                        new DateTimePoint(new DateTime(2023,11,4),2942),
                        new DateTimePoint(new DateTime(2023,11,5),3548),
                        new DateTimePoint(new DateTime(2023,11,6),3775),
                        new DateTimePoint(new DateTime(2023,11,7),2939),
                        new DateTimePoint(new DateTime(2023,11,8),6437),
                        new DateTimePoint(new DateTime(2023,11,9),4286),
                        new DateTimePoint(new DateTime(2023,11,10),4875),
                        new DateTimePoint(new DateTime(2023,11,11),4538),
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

            for (int i = 0; i < dailySerieValues.Count(); i++)
            {
                records.Add(new CsvData
                {
                    Date = dailySerieValues[i].DateTime,
                    DailyRewardPools = dailySerieValues[i].Value,
                    DailyRewardPoolPrizes = prizeSerieValues[i].Value,
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
            public double? DailyRewardPoolPrizes { get; set; }
            public double? DailyRewardPools { get; set; }
        }
    }
}
