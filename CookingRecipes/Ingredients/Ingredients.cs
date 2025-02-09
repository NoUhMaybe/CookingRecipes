
interface Ingredients
{
    int ID();
    string Name();
    string PreperationInstructions();


}

public class WheatFlour : Ingredients
{
    public int ID() => 1;
    public string Name() => "Wheat Flour";
    public string PreperationInstructions() => "Sieve. Add to other ingredients.";
}

public class CoconutFlour : Ingredients
{
    public int ID() => 2;
    public string Name() => "Coconut Flour";
    public string PreperationInstructions() => "Sieve. Add to other ingredients.";
}

public class Butter : Ingredients
{
    public int ID() => 3;
    public string Name() => "Butter";
    public string PreperationInstructions() => "Melt on low heat. Add to other ingredients.";
}

public class Chocolate : Ingredients
{
    public int ID() => 4;
    public string Name() => "Chocolate";
    public string PreperationInstructions() => "Melt on low heat. Add to other ingredients.";
}

public class Sugar : Ingredients
{
    public int ID() => 5;
    public string Name() => "Sugar";
    public string PreperationInstructions() => "Add to other ingredients.";
}

public class Cardamom : Ingredients
{
    public int ID() => 6;
    public string Name() => "Caramom";
    public string PreperationInstructions() => "Take half a teaspoon. Add to other ingredients.";
}

public class Cinnamon : Ingredients
{
    public int ID() => 7;
    public string Name() => "Cinnamon";
    public string PreperationInstructions() => "Take half a teaspoon. Add to other ingredients.";
}

public class CocoaPowder : Ingredients
{
    public int ID() => 8;
    public string Name() => "Cocoa Powder";
    public string PreperationInstructions() => "Add to other ingredients.";
}





