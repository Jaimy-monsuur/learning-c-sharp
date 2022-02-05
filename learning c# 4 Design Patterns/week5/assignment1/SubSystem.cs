using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    class SubSystem
    {
        public SubSystem()
        {
            DoSomeWork();
            DoSomeMoreWork();
        }
        public void DoSomeWork()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("SubSystem", "doing some work");
        }

        public void DoSomeMoreWork()
        {
            Logger logger = Logger.GetInstance();
            logger.Log("SubSystem", "doing some More work");
        }
    }
}
