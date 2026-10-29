class Program
{
    public static void Main()
    {
        Person myPerson = new Person("john", "schmidt", 14, 150.0);
        
        Console.WriteLine(myPerson.GetPersonInformation());


        Doctor myDoctor = new Doctor("bob", "payne", 45, 290.0, "syringe");

        Console.WriteLine(myDoctor.GetDoctorInfo());


        Police myPolice = new Police("Jeremy", "Warner", 34, 180, "Baton");
        Console.WriteLine(myPolice.GetPoliceInfo());
    }
}