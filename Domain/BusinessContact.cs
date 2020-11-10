public class BusinessContact : Contact
{
    public string Company {get; set;}

    public override string ToString()
    {
        return FirstName + " " +
            LastName + "(" +
            Company + ")";
    }
}