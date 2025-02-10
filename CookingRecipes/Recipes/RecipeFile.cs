
public static class RecipeFile
{
    private static string _filename = "";
    public static void InputFile()
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
        } while (userChoice != "1" && userChoice != "2");

        //Check if file already exists
        if (CheckIfFileExists())
        {
            OutputRecipeFormat();
            //Ask user if they want to overwrite
            Console.WriteLine("Would you like to Overwrite (y/n): ");
            userChoice = Console.ReadLine();
            //If overwrite chosen delete current file
            if (userChoice == "n" || userChoice.ToUpper() == "N")
            {
                File.Delete(_filename);
            }
        }

        while (true)
        {
            //Add a new recipe
            List<Ingredients> recipe = Recipe.Add();

            //Append new recipe to the file
            OutputRecipeIDToFile(recipe);

            //Check if user would like to enter another recipe
            Console.WriteLine("Would you like to enter another recipe (y/n): ");
            userChoice = Console.ReadLine();
            if (userChoice != "y") { break; }
        }

        OutputRecipeFormat();

    }

    public static void OutputRecipeFormat()
    {
        //Display current recipes written in file

        //Get recipes from file
        string[] recipes = File.ReadAllLines(_filename);

        //Iterate for each recipe
        int count = 1, ingredient;
        string name = "", preperation = "";
        foreach (string recipe in recipes)
        {
            Console.WriteLine($"--- Recipe #{count} ---");
            for(int i = 0; i < recipe.Length; i++)
            {
                if (char.IsDigit(recipe[i]) && char.GetNumericValue(recipe[i]) > 0 && char.GetNumericValue(recipe[i]) < 9)
                {
                    ingredient = (int)char.GetNumericValue(recipe[i]);
                    switch (ingredient)
                    {
                        case 1: //Wheat Flour
                            name = "Wheat Flour";
                            preperation = "Sieve. Add to other ingredients.";
                            break;
                        case 2: //Coconut Flour
                            name = "Coconut Flour";
                            preperation = "Sieve. Add to other ingredients.";
                            break;
                        case 3: //Butter
                            name = "Butter";
                            preperation = "Melt on low heat. Add to other ingredients.";
                            break;
                        case 4: //Chocolate
                            name = "Chocolate";
                            preperation = "Melt on low heat. Add to other ingredients.";
                            break;
                        case 5: //Sugar
                            name = "Sugar";
                            preperation = "Add to other ingredients.";
                            break;
                        case 6: //Cardamom
                            name = "Cardamom";
                            preperation = "Take half a teaspoon. Add to other ingredients.";
                            break;
                        case 7: //Cinnamon
                            name = "Cinnamon";
                            preperation = "Take half a teaspoon. Add to other ingredients.";
                            break;
                        case 8: //Cocoa Powder
                            name = "Cocoa Powder";
                            preperation = "Add to other ingredients.";
                            break;
                    }
                    Console.WriteLine($"{name}. {preperation}");
                }
            }
            Console.WriteLine(); //Starts a new line
            count++;
        }

    }

    private static void OutputRecipeIDToFile(List<Ingredients> recipe)
    {
        //Output the recipe with concatenation
        string output = "";
        for (int i = 0; i < recipe.Count; i++)
        {
            if (i == 0)//If beginning iteration of the loop
            {
                output += $"[\"{recipe[i].ID()}";
            }
            else if (i == recipe.Count - 1) //if on last iteration of loop
            {
                output += $",{recipe[i].ID()}\"]";
            }
            else //If anywhere in the middle iterations
            {
                output += $",{recipe[i].ID()}";
            }
        }
        //End on a new line
        output += "\n";

        //Testing output, to be commented out later
        //Console.WriteLine(output);

        //Write 'output' to a file
        File.AppendAllText(_filename, output);
    }

    private static bool CheckIfFileExists()
    {
        return File.Exists(_filename);
    }
}
