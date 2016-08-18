using System;
using TestingDSConsole.Repository;

namespace TestingDSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //DSRepository ds = new DSRepository();
            //ds.Samples();

            DPRepository dp = new DPRepository();
            dp.DPQuestions();

            //SearchRepository search = new SearchRepository();
            //search.SearchImplementations();

            //ArrayRepository arr = new ArrayRepository();
            //arr.ArrayImplementations();

            //Console.ReadLine();

            //SortRepository sort = new SortRepository();
            //sort.SortImplementations();


        }
    }
}
