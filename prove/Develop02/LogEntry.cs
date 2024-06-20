using System.Collections.Generic;
using System.IO;
using System.Text;

public class LogEntry
{
    public string entryDate { get; set;}
    public string entryText { get; set;}  
}


// I got this code from chatGPT, it also added the comments to make it straitforward.
public static class CsvExporter
{
    public static void ExportToCsv(LogEntry logEntry)
    {
        string filePath = @"Log.csv"; // File path for the CSV file

        // Create a StringBuilder to efficiently build the CSV content
        StringBuilder csvContent = new StringBuilder();

        // Append header (optional)
        csvContent.AppendLine("Entry Date,Entry Text");

        // Escape commas and other special characters if necessary
        string escapedEntryText = logEntry.entryText.Replace(",", ";"); // Replace commas with semicolons as an example

        // Append the values
        csvContent.AppendLine($"{logEntry.entryDate},{escapedEntryText}");

        // Write the CSV content to a file
        File.WriteAllText(filePath, csvContent.ToString());

        Console.WriteLine($"CSV exported to: {filePath}");
    }
}