using System;

public class Book
{
    public required string Title { get; set; }
    public required string ISBN { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
    public required string Publisher { get; set; }
    public required string Author { get; set; }
    public required string Category { get; set; }
    public required string Status { get; set; }

    public override string ToString()
    {
        return $" ISBN: {ISBN}, Title: {Title},Price: {Price:C}, Count: {Count}, " +
               $"Publisher: {Publisher}, Author: {Author}, Category: {Category}, Status: {Status}";
    }

}