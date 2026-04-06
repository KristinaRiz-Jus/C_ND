using System;

class Task4
{
    public static void Run()
    {
        string email = "Studentas@Mokykla.LT";

        string domain = "mokykla.lt";
        int atIndex = email.IndexOf('@');

        if (atIndex != -1)
        {
            string emailDomain = email.Substring(atIndex + 1);

            if (emailDomain.Equals(domain, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("El. paštas priklauso mokykla.lt");
            else
                Console.WriteLine("El. paštas nepriklauso mokykla.lt");
        }
        else
        {
            Console.WriteLine("El. paštas neteisingas");
        }
    }
}