using System.Runtime.CompilerServices;

namespace PageCounterApp.Services
{
    public class PageCounterService : IPageCounter
    {
        private Dictionary<string, int> pageCount = new Dictionary<string, int>();

        public int IncrementPageCount(string pageName)
        {
            if(pageCount.ContainsKey(pageName))
            {
                int count = pageCount[pageName] + 1;
                pageCount[pageName] = count;
                return count;
            }
            else
            {
                pageCount.Add(pageName, 1);
                return 1;
            }
        }
    }
}
