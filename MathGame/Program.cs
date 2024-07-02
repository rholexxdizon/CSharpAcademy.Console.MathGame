using MathGame;

var name = Helpers.GetName();
var date = DateTime.UtcNow;
Menu menu = new();
menu.ShowMenu(name, date);
