<Query Kind="Program">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

void Main()
{
	// My challenge solution
	var q = from color in ColorLib.ColorSource.WebColors
					where color.ColorName.Contains("-") ||
					IsValidHex(color.HexValue) == false
					orderby IsValidHex(color.HexValue) == false
					select new { color.ColorName, color.HexValue };

	q.Dump();

}

// Define other methods and classes here
public bool IsValidHex(string candidate)
{
	return int.TryParse(candidate, System.Globalization.NumberStyles.HexNumber, null, out _);
}

public bool IsValidHex2(string candidate)
{
	char[] validHexChars = "0123456789ABCDEFabcdef".ToCharArray();
	return (candidate.All(c => validHexChars.Contains(c)));
}
public bool IsValidHex3(string candidate)
{
	string hexPattern = "^[0-9A-Fa-f]+$";
	var regex = new Regex(hexPattern, RegexOptions.IgnoreCase);
	return regex.IsMatch(candidate);
}
