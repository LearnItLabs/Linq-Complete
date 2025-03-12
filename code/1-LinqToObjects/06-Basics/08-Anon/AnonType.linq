<Query Kind="Statements">
  <Reference Relative="..\..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// select returns a sequence of the chosen type
// IEnumerable<string>, IEnumerable<Product>

// Transform type with an anonymous type

// Portuguese titles

var q = from color in ColorLib.ColorSource.WebColors
				orderby color.ColorName
				select new {NomeDaCor = color.ColorName,FamíliaDeCores = color.ColorFamily};

q.Dump("Sequence of anonymous type");