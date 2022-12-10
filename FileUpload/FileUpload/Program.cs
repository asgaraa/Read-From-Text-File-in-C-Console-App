// See https://aka.ms/new-console-template for more information


using FileUpload.Controller;
using FileUpload.Helpers;
using FileUpload.Interface;

Helper.WriteToConsole(ConsoleColor.Red, "Select Options");
FileController fileController = new FileController();

while (true)
{

    GetMenus();


    string selectOptions = Console.ReadLine();
    int option;
    bool istrueoption = int.TryParse(selectOptions, out option);



    switch (option)
    {
        case (int)MyEnums.Menus.AddToFile:
            fileController.Sum();
            break;
     

    }
}




static void GetMenus()
{
    Helper.WriteToConsole(ConsoleColor.Green, "1 - Add To File ");

}