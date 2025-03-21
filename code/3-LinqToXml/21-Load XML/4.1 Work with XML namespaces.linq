<Query Kind="Statements" />

var root = Path.GetDirectoryName(Util.CurrentQueryPath);
root.Dump();
var upPath = @"\..\..\Data\XML\";

var path1 = @"BigStar.xml";
var path2 = @"BigStar-WithPrefix.xml";

var nonElement = XElement.Load(root + upPath + path1);
var prefixedElement = XElement.Load(root + upPath + path2);


nonElement.GetDefaultNamespace().Dump("BigStar.xml has a null namespace");
prefixedElement.GetDefaultNamespace().Dump("BigStar-withPrefix has two namepaces");
prefixedElement.GetNamespaceOfPrefix("bigstar").Dump("The prefixed namespace");
prefixedElement.GetPrefixOfNamespace ("http://bigstarcollectibles.com/course-examples").Dump("Prefix");


