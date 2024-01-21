using System;

// Packing interface
interface Packing
{
    string Pack();
}

// Concrete implementations of Packing
class Wrapper : Packing
{
    public string Pack()
    {
        return "Wrapper";
    }
}

class Bottle : Packing
{
    public string Pack()
    {
        return "Bottle";
    }
}

// Item interface
interface Item
{
    string Name();
    Packing Packing();
    float Price();
}

// Concrete Item Builder interface
interface ItemBuilder
{
    ItemBuilder Name(string name);

    ItemBuilder Packing(Packing packing);

    ItemBuilder Price(float price);

    Item Build();
}

// Concrete ItemBuilder implementation
class ConcreteItemBuilder : ItemBuilder
{
    private string itemName;
    private Packing itemPacking;
    private float itemPrice;

    public ItemBuilder Name(string name)
    {
        itemName = name;
        return this;
    }

    public ItemBuilder Packing(Packing packing)
    {
        itemPacking = packing;
        return this;
    }

    public ItemBuilder Price(float price)
    {
        itemPrice = price;
        return this;
    }

    public Item Build()
    {
        return new ConcreteItem(itemName, itemPacking, itemPrice);
    }
}

// Concrete Item implementation
class ConcreteItem : Item
{
    private readonly string name;
    private readonly Packing packing;
    private readonly float price;

    public ConcreteItem(string name, Packing packing, float price)
    {
        this.name = name;
        this.packing = packing;
        this.price = price;
    }

    public string Name()
    {
        return name;
    }

    public Packing Packing()
    {
        return packing;
    }

    public float Price()
    {
        return price;
    }
}

// Director class to construct items
class ItemDirector
{
    public Item Construct(ItemBuilder builder)
    {
        return builder.Build();
    }
}

// Client code to demonstrate the Builder Pattern
class BuilderPatternExample
{
    static void Main()
    {
        // Create a ConcreteItem using the builder
        ItemBuilder itemBuilder = new ConcreteItemBuilder();
        ItemDirector itemDirector = new ItemDirector();

        Item item = itemDirector.Construct(
            itemBuilder.Name("Dell")
                       .Packing(new Wrapper())
                       .Price(10.0f)
        );

        // Display item details
        Console.WriteLine("Item Name: " + item.Name());
        Console.WriteLine("Packing: " + item.Packing().Pack());
        Console.WriteLine("Price: " + item.Price());
    }
}
