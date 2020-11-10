using System;

public class PrivateContact : PrivateContact
{
    public string RelationType{get; set;}
    public DateTime Birthday {get; set;}

    public override string ToString()
    {
        return FirstName + " " +
            LastName + "(" +
            RelationType + ")" +
            " " +
            Birthday.ToString("yyyy/MM/dd");
    }
}