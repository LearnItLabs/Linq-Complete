<Query Kind="Statements">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
</Query>

#region Load BigStar.json file
var root = Path.GetDirectoryName(Util.CurrentQueryPath);
var upPath = @"\..\..\Data\JSON\";
var path = @"BigStar.json";
JObject collectibles = JObject.Parse(File.ReadAllText(root + upPath + path));


#endregion

collectibles.Dump();
//// Parse JSON into a JObject
//JObject jsonObject = JObject.Parse(json);

