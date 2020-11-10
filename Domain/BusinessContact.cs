public class BusinessContact : BusinessContact
{
    public string Company {get; set;}

    public override string ToString()
    {
        return FirstName + " " +
            LastName + "(" +
            Company + ")";
    }
}