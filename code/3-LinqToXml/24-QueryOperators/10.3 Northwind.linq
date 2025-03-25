<Query Kind="Statements" />

#region Load northwind.xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"northwind.xml";
var nWind = XElement.Load(root + upPath + path);
#endregion
// group by Element
var q1 = from customer in nWind.Descendants("Customer")
				 group customer by customer.Element("Country").Value
				 into countries
				 select new { countries.Key, CompaniesInCountry = countries.Count()} ;

q1.Dump();