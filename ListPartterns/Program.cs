var numbers = new[] { 1, 2, 3 };

// Matching with a value
Console.WriteLine(numbers is [1, 2, 3]);
Console.WriteLine(numbers is [1, 2, 4]);
Console.WriteLine(numbers is [1, 2, 3, 4]);

// Matching with an expression
Console.WriteLine(numbers is [0 or 1, <= 2, >= 3]);

// Matching with variables
if (numbers is [var first, .. var rest])
{
    Console.WriteLine(first);
    Console.WriteLine(string.Join(", ", rest));
}

// Match and assign to a variable with Swith
var emptyCountries = Array.Empty<string>();
var ukOnly = new[] { "United Kingdom" };
var euCountries = new[] { "France", "Germany" };
var seaCountries = new[] { "VietNam", "Thailand", "Singapore" };

foreach (var item in new[] { emptyCountries, ukOnly, euCountries, seaCountries })
{
    var countryResolve = item switch
    {
        [] => "There is no country",
        [var singleCountry] => $"There is only one country which is {singleCountry}",
        [var firstCountry, var secondCountry] => $"There is only 2 countries which are {firstCountry} and {secondCountry}",
        _ => "Error: Other cases aren't handled"
    };
    Console.WriteLine(countryResolve);
}