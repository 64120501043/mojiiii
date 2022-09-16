using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program{
    public static void Main(string[] args) {
        int University;
        Console.WriteLine("-------------------------------");
        Console.WriteLine("1 = ChulalongkornUniversity ,2 = MahidolUniversity ,3 = LatKrabangUniversity ,4 = KhonKaenUniversity , 5 = KmuttUniversity");
        Console.WriteLine("Choose your University :");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("1 = ChulalongkornAgent ,2 = MahidoAgent ,3 = LatKrabangAgent, 4 = KhonKaenAgent, 5 = KmuttAgent");
        Console.WriteLine("Choose your Agant University :");
        University = int.Parse(Console.ReadLine());
        switch(University)
        {
            case 1 : Universityy.ChulalongkornUniversity();
                     Universityy.ChulalongkornAgent();
                     break;
            case 2 : Universityy.MahidolUniversity();
                     Universityy.MahidoAgent();
                     break;
            case 3 : Universityy.LatKrabangUniversity();
                     Universityy.LatKrabangAgent();
                     break;
            case 4 : Universityy.KhonKaenUniversity();
                     Universityy.KhonKaenAgent();
                     break;
            case 5 : Universityy.KmuttUniversity();
                     Universityy.KmuttAgent();
                     break;
            default: Console.WriteLine("xxxxxxxxxxxxxxERRORxxxxxxxxxxx");
                     break;
        }

    }
}