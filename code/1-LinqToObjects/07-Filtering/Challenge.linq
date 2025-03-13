<Query Kind="Statements">
  <Reference Relative="..\..\Data\Assemblies\ColorLib\ColorLib.dll">D:\repos\LearnItLabs\Linq-Complete\code\Data\Assemblies\ColorLib\ColorLib.dll</Reference>
</Query>

// Challenge

// QA reports problems with the data
// 1. Some color names contain hyphens (-), which are not allowed.
// 2. Some HexValues contain invalid charactors.

// Goal
// Write a single LINQ query expression that:
// - Returns all colors with invalid color names (containing hyphens) 
// - AND 
// - Returns all colors with invalid HexValues 

// Hexadecimal validation rules:
// Valid hexadecimal charactors (0-9, A, B, C, D, E, F)
// Example: FFFF00 is valid
// Example: FF34T3 is invalid (contains 'T', which is not a valid hex character)

// Requirement:
// Combine both tests into a single query expression!

// use this data source
var colors = ColorLib.ColorSource.WebColors ;

colors.Dump();