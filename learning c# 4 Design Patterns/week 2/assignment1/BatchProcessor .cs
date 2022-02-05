using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class BatchProcessor
    {
        private List<BigDataLoader> dataLoaderslist;
        public BatchProcessor()
        {
            dataLoaderslist = new List<BigDataLoader>();
        }
        public void AddBigDataLoader(BigDataLoader loader)
        {
            dataLoaderslist.Add(loader);
        }

        public void Process()
        {
            foreach (BigDataLoader l in dataLoaderslist)
            {
                l.ETL_Method();
            }
        }
    }
}
