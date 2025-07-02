using System;
public class guest : Iguest
{
    public string Name { get; set; }
    public int NumberOfGuests { get; set; }
  
    public guest(string name, int numberOfGuests)
    {
        Name = name;
        NumberOfGuests = numberOfGuests;
      
    }
}
