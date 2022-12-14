// See https://aka.ms/new-console-template for more information

using App.Helpers;
using App.Repository;
using App.Services;


Helper.WriteToConsole( "Add to File Root");

string k = Console.ReadLine();
var source = new FileRepository();
var nums = source.GetNumbers(k);

var factory = new ControllerFactory();





var controller = factory.CreateController( nums);



//var result = controller.DoOperation();
