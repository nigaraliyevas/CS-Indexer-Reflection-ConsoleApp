using AcademyApp.Helper;

Helper.ChangeColor(ConsoleColor.Yellow,"Wellcome To AcademyApp");
Helper.ChangeColor(ConsoleColor.Gray,"Enter A Number: 1.CreateStudent 2.GetAllStudents 0.Exit");
Menu: var message=Console.ReadLine();
var result=int.TryParse(message, out int numMenu);
while (true)
{
    if (result&&numMenu>0&&numMenu<3)
    {

    }
    else if (numMenu == 0)
    {
        break;
    }
    else
    {
        Helper.ChangeColor(ConsoleColor.Red,"Please Enter Correct Number...");
        goto Menu;
    }
}
