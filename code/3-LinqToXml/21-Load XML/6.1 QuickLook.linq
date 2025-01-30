<Query Kind="Statements" />

#region Load Northwind xml file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\XML\";
var path = @"Northwind.xml";
var xmlData = XElement.Load(root + upPath + path);
#endregion


int orderCount = (int)xmlData.Descendants("Order").Count();
orderCount.Dump("Total orders");

var query = from c in xmlData.Element("Customers").Elements("Customer")
						from od in c.Element("Orders").Elements("Order")
						where (decimal)od.Element("Freight") > 50  // Filter

						orderby (string)c.Element("CompanyName")

						select new {
							OrderNum = (int)od.Element("OrderID"),
							CustomerName = (string)c.Element("CompanyName"),
							FreightCost = (decimal)od.Element("Freight"),
							Country = (string)c.Element("Country")

						};

query.Dump();