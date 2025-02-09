
public abstract class Ingredients
{
    public abstract int ID();
    public abstract string Name();
    public abstract string PreperationInstructions();

    public static void ListIngredients()
    {
        Console.WriteLine("Availble ingredients are:");
        Console.WriteLine("1. Wheat Flour");
        Console.WriteLine("2. Coconut Flour");
        Console.WriteLine("3. Butter");
        Console.WriteLine("4. Chocolate");
        Console.WriteLine("5. Sugar");
        Console.WriteLine("6. Cardamom");
        Console.WriteLine("7. Cinnamon");
        Console.WriteLine("8. Cocoa Powder");
    }
}

public class WheatFlour : Ingredients
{
    public override int ID() => 1;
    public override string Name() => "Wheat Flour";
    public override string PreperationInstructions() => "Sieve. Add to other ingredients.";
}

public class CoconutFlour : Ingredients
{
    public override int ID() => 2;
    public override string Name() => "Coconut Flour";
    public override string PreperationInstructions() => "Sieve. Add to other ingredients.";
}

public class Butter : Ingredients
{
    public override int ID() => 3;
    public override string Name() => "Butter";
    public override string PreperationInstructions() => "Melt on low heat. Add to other ingredients.";
}

public class Chocolate : Ingredients
{
    public override int ID() => 4;
    public override string Name() => "Chocolate";
    public override string PreperationInstructions() => "Melt on low heat. Add to other ingredients.";
}

public class Sugar : Ingredients
{
    public override int ID() => 5;
    public override string Name() => "Sugar";
    public override string PreperationInstructions() => "Add to other ingredients.";
}

public class Cardamom : Ingredients
{
    public override int ID() => 6;
    public override string Name() => "Caramom";
    public override string PreperationInstructions() => "Take half a teaspoon. Add to other ingredients.";
}

public class Cinnamon : Ingredients
{
    public override int ID() => 7;
    public override string Name() => "Cinnamon";
    public override string PreperationInstructions() => "Take half a teaspoon. Add to other ingredients.";
}

public class CocoaPowder : Ingredients
{
    public override int ID() => 8;
    public override string Name() => "Cocoa Powder";
    public override string PreperationInstructions() => "Add to other ingredients.";
}





