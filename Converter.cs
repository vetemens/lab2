using System;


class Converter
{

    public static void Main(String[] args)
    {
        int choice;
        Console.WriteLine("Выберите :\n 1- Гривну в рубль \n 2- Эвро в гривну \n 3- Доллар в гривну \n 4- Рубль в гривну");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                double UahtoRub = 2.69;
                double uah;


                Console.WriteLine("Введите сумму в UAH:");

                uah = double.Parse(Console.ReadLine());

                Console.WriteLine(uah + " UAH в RUB = " + uah * UahtoRub);
                break;
            case 2:
                double EurtoUah = 31.96;
                double eur;
                Console.WriteLine("Введите сумму в EUR:");

                eur = double.Parse(Console.ReadLine());

                Console.WriteLine(eur + " EUR в RUB = " + eur * EurtoUah);
                break;
            case 3:
                double UsdtoUah = 28.00;
                double usd;
                Console.WriteLine("Введите сумму в USD:");

                usd = double.Parse(Console.ReadLine());

                Console.WriteLine(usd + " USD в RUB = " + usd * UsdtoUah);
                break;
            case 4:
                double RubtoUah = 0.37;
                double rub;
                Console.WriteLine("Введите сумму в RUB:");

                rub = double.Parse(Console.ReadLine());

                Console.WriteLine(rub + " RUB в RUB = " + rub * RubtoUah);
                break;






        }















    }
    


}