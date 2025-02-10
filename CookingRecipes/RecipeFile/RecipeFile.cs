
public class RecipeFile
{
    private string _filename = "";
    public void InputFile(List<Ingredients> recipe)
    {
        //Initial variable declaration
        string userChoice = "";

        //Prompt user for a filename/type
        do
        {
            Console.WriteLine("Enter a filename for the recipe (Ex recipes): ");
            _filename = Console.ReadLine();
            if(_filename.Length == 0) { continue; }
            Console.WriteLine("Would you like it to be a [1].txt or [2].json: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    _filename += ".txt";
                    break;
                case "2":
                    _filename += ".json";
                    break;
                default:
                    break;
            }
        } while (userChoice != "1" || userChoice != "2");

        //Check if file already exists
        if (CheckFile())
        {
            this.OutputRecipe();
            //Fixme: ask user if they want to overwrite
            Console.WriteLine("Would you like to Overwrite (y/n): ");
            var userChoice = Console.ReadLine();
            //Fixme: either append or delete and start appending file depending on users choice to overwrite
        }
    }

    public void OutputRecipe()
    {
        //Fixme: Display current recipes written in file
    }

    private bool CheckFile()
    {
        if (File.Exists(_filename)) {return true;}
        return false;
    }
}
