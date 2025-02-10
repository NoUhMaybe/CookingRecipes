using System;
using System.Collections.Immutable;
using System.IO;

var recipeList = new RecipeFile();

//Add a new recipe
List<Ingredients> recipe = Recipe.Add();

//Fixme: Move the following function to a class file
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

//Testing output, to be commented out later
Console.WriteLine(output);

//FIXME: Figure out how to write 'output' to a file

//Exit
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

