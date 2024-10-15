using System.Reflection.Emit;

namespace Names;

internal static class HeatmapTask
{
    public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
    {
        var xLabel = FillLable(new string[30], 2);
        var yLabel = FillLable(new string[12], 1);
        double[,] data = new double[30, 12];
        foreach (var elem in names)
        {
            if (elem.BirthDate.Day != 1)
                data[elem.BirthDate.Day - 2, elem.BirthDate.Month - 1] += 1;
        }
        return new HeatmapData(
            "Пример карты интенсивностей",
            data,
            xLabel,
            yLabel);
    }

    public static string[] FillLable(string[] label, int begin)
    {
        for (int i = 0; i < label.Length; i++)
            label[i] = (i + begin).ToString();
        return label;
    }
}
