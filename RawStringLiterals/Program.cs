using System.Text;

var sb = new StringBuilder();

var xmlText = """<?xml version="1.0" encoding="UTF-8"?> """;
sb.AppendLine("XML:");
sb.AppendLine(xmlText);

Console.WriteLine(sb.ToString());

sb.Clear();

var jsonText = """
    {
        "name": "Anh Bui"
    }
    """;
sb.AppendLine("JSON:");
sb.AppendLine(jsonText);
Console.WriteLine(sb.ToString());

sb.Clear();

var name = "Anh Bui";
// Use the double bracket to distinguish with single bracket of JSON
var jsonWithStringInterpolation = $$"""
    {
        "name": "{{name}}"
    }
    """;
sb.AppendLine("JSON with string interpolation:");
sb.AppendLine(jsonWithStringInterpolation);
Console.WriteLine(sb.ToString());