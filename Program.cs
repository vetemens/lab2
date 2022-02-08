class Address
{
    public int index;
    public string country;
    public string city;
    public string street;
    public int house;
    public int apartment;

    public int Index
    {
        get
        {
            return index;
        }
        set
        {
            index = value;
        }

    }
    public string Name
    {
        get { return country; }
        set { country = value; }
    }
    public string Name1
    {
        get { return city; }
        set { city = value; }
    }
    public string Name2
    {
        get { return street; }
        set { street = value; }
    }
    public int House
    {
        get { return house; }
        set { house = value; }
    }
    public int Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
class Myaddress
    {
        static void Main(string[] args)
        {
            Address a = new Address();
            a.index = 08300;
            a.country = "Ukraine";
            a.city = "Kiev";
            a.street = "Shevchenka";
            a.house = 228;
            a.apartment = 17;
            Console.WriteLine($"index:{a.index}, country:{a.country}, city:{a.city}, street:{a.street}, house:{a.house}, apartment:{a.apartment},");


        }
            



    }









}








