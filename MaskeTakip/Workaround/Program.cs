using Business.Concrete;
using Entities.Concrete;

public class Program
    {
        private static void Main(string[] args)
        {

            SayHi(name:"Berke");
            SayHi();
            int result = Addition(50);

            string stuedent1 = "Berke";
            string stuedent2 = "Dogukan";
            string stuedent3 = "Ahmet";

            string[] stuedents = new string[3];
            stuedents[0] = "Berke";
            stuedents[1] = "Dogukan";
            stuedents[2] = "Ahmet";

            stuedents = new string[4];

            for (int i = 0; i < stuedents.Length; i++)
            {
                Console.WriteLine(stuedents[i]);
            }

            string[] cities1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] cities2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            foreach (string city in cities1)
            {
                Console.WriteLine(city);
            }

            List<string> newCities1 = new List<string>{ "Ankara 1", "İstanbul 1", "İzmir 1" };
            newCities1.Add(item: "Bartın 1");
            foreach (var city in newCities1)
            {
                Console.WriteLine(city);
            }


        Citizen citizen1 = new Citizen();
        citizen1.Name = "Hamza Berke Can";
        citizen1.Surname = "Kösali";
        citizen1.NationalIdentity = 12345678910;
        citizen1.BornYear = 2002;

        PTTManager pttManager = new PTTManager(new CitizenManager());
        pttManager.GiveMask(citizen1);

            Console.ReadLine();
        }

        static void SayHi(string name="Noname")
        {
            Console.WriteLine("Hello " + name);
        }

        static int Addition(int sayi1 = 7, int sayi2 = 9) 
        {
            int result = sayi2 + sayi1;
            Console.WriteLine("Toplam " + result.ToString());
            return result; 
        }
    }