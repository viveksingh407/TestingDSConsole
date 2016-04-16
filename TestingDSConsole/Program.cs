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

            //DPRepository dp = new DPRepository();
            //dp.DPQuestions();

            SearchRepository search = new SearchRepository();
            search.SearchImplementations();

            SortRepository sort = new SortRepository();
            sort.SortImplementations();
        }
    }
}
