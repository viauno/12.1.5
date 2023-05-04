namespace _12._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateUser();
        }
        class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        static void OnLogIn(string name, bool ispremium)
        {
            Console.WriteLine("Здравствуйте, {0}", name);
            if (!ispremium) ShowAds();
        }

        static void GenerateUser()
        {
            User user = new User();
            user.Login = "1234";
            user.Name = "Vova";
            Random rnd = new Random();
            int value = rnd.Next(1, 3);
            Console.WriteLine(value);
            user.IsPremium = value == 1 ? true : false;
            OnLogIn(user.Name, user.IsPremium);
        }

    }
    
}