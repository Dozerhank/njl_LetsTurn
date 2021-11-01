using System;

/****Why was this so easy****/

public interface ITurnable
{
    void Turn();
}

class Page : ITurnable
{
    public Page()
    {

    }

    public void Turn()
    {
        Console.WriteLine("You turn a page in a book");
    }
}

class Corner : ITurnable
{
    public void Turn()
    {
        Console.WriteLine("You turn corners to go around the block");
    }
}

class Pancake : ITurnable
{
    public void Turn()
    {
        Console.WriteLine("You turn a pancake when it's done on one side");
    }
}

class Leaf : ITurnable
{
    public void Turn()
    {
        Console.WriteLine("A leaf turns colors in the fall");
    }
}