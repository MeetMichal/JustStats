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
    public partial class LuckyDrawsTotalChart : BaseChartComponent
    {
        private static readonly SKColor black = SKColors.Black;


        public LuckyDrawsTotalChart()
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
                    Name = "Total number of Lucky Draws",
                    NamePaint = new SolidColorPaint(Colors.SerieBlue),
                    LabelsPaint = new SolidColorPaint(Colors.SerieBlue),
                    TicksPaint = new SolidColorPaint(Colors.SerieBlue),
                    SubticksPaint = new SolidColorPaint(Colors.SerieBlue),
                },
                new Axis
                {
                    Name = "Total Lucky Draws prizes [$]",
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
                    Name="Total number of Lucky Draws",
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
                        new DateTimePoint(new DateTime(2023,7,21),9),
                        new DateTimePoint(new DateTime(2023,7,24),1610),
                        new DateTimePoint(new DateTime(2023,7,25),2716),
                        new DateTimePoint(new DateTime(2023,7,26),4371),
                        new DateTimePoint(new DateTime(2023,7,27),6170),
                        new DateTimePoint(new DateTime(2023,7,28),7521),
                        new DateTimePoint(new DateTime(2023,7,29),8176),
                        new DateTimePoint(new DateTime(2023,7,30),8774),
                        new DateTimePoint(new DateTime(2023,7,31),9496),
                        new DateTimePoint(new DateTime(2023,8,1),10226),
                        new DateTimePoint(new DateTime(2023,8,2),11026),
                        new DateTimePoint(new DateTime(2023,8,3),11718),
                        new DateTimePoint(new DateTime(2023,8,4),12363),
                        new DateTimePoint(new DateTime(2023,8,5),12980),
                        new DateTimePoint(new DateTime(2023,8,6),13591),
                        new DateTimePoint(new DateTime(2023,8,7),14198),
                        new DateTimePoint(new DateTime(2023,8,8),14655),
                        new DateTimePoint(new DateTime(2023,8,9),15005),
                        new DateTimePoint(new DateTime(2023,8,10),15326),
                        new DateTimePoint(new DateTime(2023,8,11),15847),
                        new DateTimePoint(new DateTime(2023,8,12),16332),
                        new DateTimePoint(new DateTime(2023,8,13),16855),
                        new DateTimePoint(new DateTime(2023,8,14),17385),
                        new DateTimePoint(new DateTime(2023,8,15),17960),
                        new DateTimePoint(new DateTime(2023,8,16),18523),
                        new DateTimePoint(new DateTime(2023,8,17),18993),
                        new DateTimePoint(new DateTime(2023,8,18),19533),
                        new DateTimePoint(new DateTime(2023,8,19),20178),
                        new DateTimePoint(new DateTime(2023,8,20),20795),
                        new DateTimePoint(new DateTime(2023,8,21),21413),
                        new DateTimePoint(new DateTime(2023,8,22),21912),
                        new DateTimePoint(new DateTime(2023,8,23),22372),
                        new DateTimePoint(new DateTime(2023,8,24),22884),
                        new DateTimePoint(new DateTime(2023,8,25),23283),
                        new DateTimePoint(new DateTime(2023,8,26),23680),
                        new DateTimePoint(new DateTime(2023,8,27),24044),
                        new DateTimePoint(new DateTime(2023,8,28),24442),
                        new DateTimePoint(new DateTime(2023,8,29),24821),
                        new DateTimePoint(new DateTime(2023,8,30),25159),
                        new DateTimePoint(new DateTime(2023,8,31),25515),
                        new DateTimePoint(new DateTime(2023,9,1),25829),
                        new DateTimePoint(new DateTime(2023,9,2),26113),
                        new DateTimePoint(new DateTime(2023,9,3),26397),
                        new DateTimePoint(new DateTime(2023,9,4),26693),
                        new DateTimePoint(new DateTime(2023,9,5),26962),
                        new DateTimePoint(new DateTime(2023,9,6),27242),
                        new DateTimePoint(new DateTime(2023,9,7),27584),
                        new DateTimePoint(new DateTime(2023,9,8),27869),
                        new DateTimePoint(new DateTime(2023,9,9),28089),
                        new DateTimePoint(new DateTime(2023,9,10),28319),
                        new DateTimePoint(new DateTime(2023,9,11),28559),
                        new DateTimePoint(new DateTime(2023,9,12),28792),
                        new DateTimePoint(new DateTime(2023,9,13),29008),
                        new DateTimePoint(new DateTime(2023,9,14),29219),
                        new DateTimePoint(new DateTime(2023,9,15),29830),
                        new DateTimePoint(new DateTime(2023,9,16),30339),
                        new DateTimePoint(new DateTime(2023,9,17),30818),
                        new DateTimePoint(new DateTime(2023,9,18),31360),
                        new DateTimePoint(new DateTime(2023,9,19),31835),
                        new DateTimePoint(new DateTime(2023,9,20),32228),
                        new DateTimePoint(new DateTime(2023,9,21),32544),
                        new DateTimePoint(new DateTime(2023,9,22),32867),
                        new DateTimePoint(new DateTime(2023,9,23),33174),
                        new DateTimePoint(new DateTime(2023,9,24),33431),
                        new DateTimePoint(new DateTime(2023,9,25),33758),
                        new DateTimePoint(new DateTime(2023,9,26),34069),
                        new DateTimePoint(new DateTime(2023,9,27),34377),
                        new DateTimePoint(new DateTime(2023,9,28),34681),
                        new DateTimePoint(new DateTime(2023,9,29),34949),
                        new DateTimePoint(new DateTime(2023,9,30),35235),
                        new DateTimePoint(new DateTime(2023,10,1),35517),
                        new DateTimePoint(new DateTime(2023,10,2),35849),
                        new DateTimePoint(new DateTime(2023,10,3),36111),
                        new DateTimePoint(new DateTime(2023,10,4),36394),
                        new DateTimePoint(new DateTime(2023,10,5),36653),
                        new DateTimePoint(new DateTime(2023,10,6),36901),
                        new DateTimePoint(new DateTime(2023,10,7),37155),
                        new DateTimePoint(new DateTime(2023,10,8),37397),
                        new DateTimePoint(new DateTime(2023,10,9),37632),
                        new DateTimePoint(new DateTime(2023,10,10),37887),
                        new DateTimePoint(new DateTime(2023,10,11),38218),
                        new DateTimePoint(new DateTime(2023,10,12),38537),
                        new DateTimePoint(new DateTime(2023,10,13),39006),
                        new DateTimePoint(new DateTime(2023,10,14),39424),
                        new DateTimePoint(new DateTime(2023,10,15),39795),
                        new DateTimePoint(new DateTime(2023,10,16),40220),
                        new DateTimePoint(new DateTime(2023,10,17),40577),
                        new DateTimePoint(new DateTime(2023,10,18),40891),
                        new DateTimePoint(new DateTime(2023,10,19),41198),
                        new DateTimePoint(new DateTime(2023,10,20),41718),
                        new DateTimePoint(new DateTime(2023,10,21),42259),
                        new DateTimePoint(new DateTime(2023,10,22),42787),
                        new DateTimePoint(new DateTime(2023,10,23),43262),
                        new DateTimePoint(new DateTime(2023,10,24),43740),
                        new DateTimePoint(new DateTime(2023,10,25),44171),
                        new DateTimePoint(new DateTime(2023,10,26),44598),
                        new DateTimePoint(new DateTime(2023,10,27),45008),
                        new DateTimePoint(new DateTime(2023,10,28),45478),
                        new DateTimePoint(new DateTime(2023,10,29),45873),
                        new DateTimePoint(new DateTime(2023,10,30),46330),
                        new DateTimePoint(new DateTime(2023,10,31),46736),
                        new DateTimePoint(new DateTime(2023,11,1),47132),
                        new DateTimePoint(new DateTime(2023,11,2),47500),
                        new DateTimePoint(new DateTime(2023,11,3),47952),
                        new DateTimePoint(new DateTime(2023,11,4),48354),
                        new DateTimePoint(new DateTime(2023,11,5),48795),
                        new DateTimePoint(new DateTime(2023,11,6),49256),
                        new DateTimePoint(new DateTime(2023,11,7),49701),
                        new DateTimePoint(new DateTime(2023,11,8),50093),
                        new DateTimePoint(new DateTime(2023,11,9),50493),
                        new DateTimePoint(new DateTime(2023,11,10),50973),
                        new DateTimePoint(new DateTime(2023,11,11),51436),
                    }
                },
                new LineSeries<DateTimePoint>
                {
                    Name = "Total Lucky Draws prizes [$]",
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
                        new DateTimePoint(new DateTime(2023,7,24),14439),
                        new DateTimePoint(new DateTime(2023,7,25),26623),
                        new DateTimePoint(new DateTime(2023,7,26),37487),
                        new DateTimePoint(new DateTime(2023,7,27),49260),
                        new DateTimePoint(new DateTime(2023,7,28),57117),
                        new DateTimePoint(new DateTime(2023,7,29),60569),
                        new DateTimePoint(new DateTime(2023,7,30),63479),
                        new DateTimePoint(new DateTime(2023,7,31),66678),
                        new DateTimePoint(new DateTime(2023,8,1),71342),
                        new DateTimePoint(new DateTime(2023,8,2),75631),
                        new DateTimePoint(new DateTime(2023,8,3),78755),
                        new DateTimePoint(new DateTime(2023,8,4),81707),
                        new DateTimePoint(new DateTime(2023,8,5),85189),
                        new DateTimePoint(new DateTime(2023,8,6),88533),
                        new DateTimePoint(new DateTime(2023,8,7),91386),
                        new DateTimePoint(new DateTime(2023,8,8),93638),
                        new DateTimePoint(new DateTime(2023,8,9),96115),
                        new DateTimePoint(new DateTime(2023,8,10),97941),
                        new DateTimePoint(new DateTime(2023,8,11),101287),
                        new DateTimePoint(new DateTime(2023,8,12),103554),
                        new DateTimePoint(new DateTime(2023,8,13),106446),
                        new DateTimePoint(new DateTime(2023,8,14),109445),
                        new DateTimePoint(new DateTime(2023,8,15),112440),
                        new DateTimePoint(new DateTime(2023,8,16),114680),
                        new DateTimePoint(new DateTime(2023,8,17),117211),
                        new DateTimePoint(new DateTime(2023,8,18),119511),
                        new DateTimePoint(new DateTime(2023,8,19),122601),
                        new DateTimePoint(new DateTime(2023,8,20),125299),
                        new DateTimePoint(new DateTime(2023,8,21),128234),
                        new DateTimePoint(new DateTime(2023,8,22),131295),
                        new DateTimePoint(new DateTime(2023,8,23),133901),
                        new DateTimePoint(new DateTime(2023,8,24),137287),
                        new DateTimePoint(new DateTime(2023,8,25),139551),
                        new DateTimePoint(new DateTime(2023,8,26),141997),
                        new DateTimePoint(new DateTime(2023,8,27),143405),
                        new DateTimePoint(new DateTime(2023,8,28),145491),
                        new DateTimePoint(new DateTime(2023,8,29),147631),
                        new DateTimePoint(new DateTime(2023,8,30),149208),
                        new DateTimePoint(new DateTime(2023,8,31),151182),
                        new DateTimePoint(new DateTime(2023,9,1),154169),
                        new DateTimePoint(new DateTime(2023,9,2),156423),
                        new DateTimePoint(new DateTime(2023,9,3),158004),
                        new DateTimePoint(new DateTime(2023,9,4),159295),
                        new DateTimePoint(new DateTime(2023,9,5),160918),
                        new DateTimePoint(new DateTime(2023,9,6),162588),
                        new DateTimePoint(new DateTime(2023,9,7),165389),
                        new DateTimePoint(new DateTime(2023,9,8),167249),
                        new DateTimePoint(new DateTime(2023,9,9),168114),
                        new DateTimePoint(new DateTime(2023,9,10),169359),
                        new DateTimePoint(new DateTime(2023,9,11),170632),
                        new DateTimePoint(new DateTime(2023,9,12),172253),
                        new DateTimePoint(new DateTime(2023,9,13),173469),
                        new DateTimePoint(new DateTime(2023,9,14),175070),
                        new DateTimePoint(new DateTime(2023,9,15),178989),
                        new DateTimePoint(new DateTime(2023,9,16),181458),
                        new DateTimePoint(new DateTime(2023,9,17),183897),
                        new DateTimePoint(new DateTime(2023,9,18),187075),
                        new DateTimePoint(new DateTime(2023,9,19),189310),
                        new DateTimePoint(new DateTime(2023,9,20),191222),
                        new DateTimePoint(new DateTime(2023,9,21),193085),
                        new DateTimePoint(new DateTime(2023,9,22),194400),
                        new DateTimePoint(new DateTime(2023,9,23),195840),
                        new DateTimePoint(new DateTime(2023,9,24),197150),
                        new DateTimePoint(new DateTime(2023,9,25),198977),
                        new DateTimePoint(new DateTime(2023,9,26),200761),
                        new DateTimePoint(new DateTime(2023,9,27),202386),
                        new DateTimePoint(new DateTime(2023,9,28),204423),
                        new DateTimePoint(new DateTime(2023,9,29),205933),
                        new DateTimePoint(new DateTime(2023,9,30),208147),
                        new DateTimePoint(new DateTime(2023,10,1),211839),
                        new DateTimePoint(new DateTime(2023,10,2),214020),
                        new DateTimePoint(new DateTime(2023,10,3),215108),
                        new DateTimePoint(new DateTime(2023,10,4),216143),
                        new DateTimePoint(new DateTime(2023,10,5),217237),
                        new DateTimePoint(new DateTime(2023,10,6),219079),
                        new DateTimePoint(new DateTime(2023,10,7),220265),
                        new DateTimePoint(new DateTime(2023,10,8),221840),
                        new DateTimePoint(new DateTime(2023,10,9),222991),
                        new DateTimePoint(new DateTime(2023,10,10),223956),
                        new DateTimePoint(new DateTime(2023,10,11),225196),
                        new DateTimePoint(new DateTime(2023,10,12),226953),
                        new DateTimePoint(new DateTime(2023,10,13),228353),
                        new DateTimePoint(new DateTime(2023,10,14),230155),
                        new DateTimePoint(new DateTime(2023,10,15),231394),
                        new DateTimePoint(new DateTime(2023,10,16),233000),
                        new DateTimePoint(new DateTime(2023,10,17),234315),
                        new DateTimePoint(new DateTime(2023,10,18),235664),
                        new DateTimePoint(new DateTime(2023,10,19),236815),
                        new DateTimePoint(new DateTime(2023,10,20),238053),
                        new DateTimePoint(new DateTime(2023,10,21),239242),
                        new DateTimePoint(new DateTime(2023,10,22),240559),
                        new DateTimePoint(new DateTime(2023,10,23),241874),
                        new DateTimePoint(new DateTime(2023,10,24),243325),
                        new DateTimePoint(new DateTime(2023,10,25),244500),
                        new DateTimePoint(new DateTime(2023,10,26),245782),
                        new DateTimePoint(new DateTime(2023,10,27),246890),
                        new DateTimePoint(new DateTime(2023,10,28),248279),
                        new DateTimePoint(new DateTime(2023,10,29),249430),
                        new DateTimePoint(new DateTime(2023,10,30),250786),
                        new DateTimePoint(new DateTime(2023,10,31),252469),
                        new DateTimePoint(new DateTime(2023,11,1),254329),
                        new DateTimePoint(new DateTime(2023,11,2),255527),
                        new DateTimePoint(new DateTime(2023,11,3),256871),
                        new DateTimePoint(new DateTime(2023,11,4),258273),
                        new DateTimePoint(new DateTime(2023,11,5),259765),
                        new DateTimePoint(new DateTime(2023,11,6),261310),
                        new DateTimePoint(new DateTime(2023,11,7),262735),
                        new DateTimePoint(new DateTime(2023,11,8),264093),
                        new DateTimePoint(new DateTime(2023,11,9),265408),
                        new DateTimePoint(new DateTime(2023,11,10),267776),
                        new DateTimePoint(new DateTime(2023,11,11),269474),
                    }
                }
            };
        }

        public override byte[] DownloadChartData()
        {
            var totalSerie = Series[0].As<LineSeries<DateTimePoint>>();
            var prizeSerie = Series[1].As<LineSeries<DateTimePoint>>();

            var totalSerieValues = totalSerie.Values.ToList();
            var prizeSerieValues = prizeSerie.Values.ToList();
            var records = new List<CsvData>();

            for (int i = 0; i < totalSerieValues.Count(); i++)
            {
                records.Add(new CsvData
                {
                    Date = totalSerieValues[i].DateTime,
                    TotaDraws = totalSerieValues[i].Value,
                    TotalPrizes = prizeSerieValues[i].Value,
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
            public double? TotalPrizes { get; set; }
            public double? TotaDraws { get; set; }
        }
    }
}
