namespace Names;

internal static class HistogramTask
{
    public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
    {
        string[] xLabel = new string[31];
        for (int i = 0; i < xLabel.Length; i++)
        {
            xLabel[i] = (i + 1).ToString();
        }

        var yLabel = new double[31];
        foreach (var elem in names)
        {
            if (elem.Name == name && elem.BirthDate.Day != 1)
            {
                yLabel[elem.BirthDate.Day - 1]++;
            }
        }

        return new HistogramData(
            $"Рождаемость людей с именем '{name}'",
                xLabel,
            yLabel);
    }
}