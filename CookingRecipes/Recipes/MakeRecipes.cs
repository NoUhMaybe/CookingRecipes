
public static class Recipe
{
    public static List<Ingredients> Add()
    {
        List<Ingredients> newRecipe = new List<Ingredients>();
        Ingredients.ListIngredients();

        while (true)
        {
            Console.WriteLine("Add an ingredient by its ID number and type anything else to finish.");
            var userInput = Console.ReadLine();
            bool tryParse = int.TryParse(userInput, out int result);
            if (!tryParse || result < 1 || result > 8) { break; }
            switch(result)
            {
                case 1:
                    newRecipe.Add(new WheatFlour());
                    break;
                case 2:
                    newRecipe.Add(new CoconutFlour());
                    break;
                case 3:
                    newRecipe.Add(new Butter());
                    break;
                case 4:
                    newRecipe.Add(new Chocolate());
                    break;
                case 5:
                    newRecipe.Add(new Sugar());
                    break;
                case 6:
                    newRecipe.Add(new Cardamom());
                    break;
                case 7:
                    newRecipe.Add(new Cinnamon());
                    break;
                case 8:
                    newRecipe.Add(new CocoaPowder());
                    break;
            }

        }

        return newRecipe;
    }

}
