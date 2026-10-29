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

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

        foreach(Person person in myPeople)
        {
            if(person is Doctor doctor)
            {
                Console.WriteLine(doctor.GetDoctorInfo());
            }
            else if(person is Police police)
            {
                Console.WriteLine(police.GetPoliceInfo());
            }
            else
            {
                Console.WriteLine(person.GetPersonInformation());    
            }
            
        }

    }
}