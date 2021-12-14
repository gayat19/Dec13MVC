using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Services
{
    public class DummyService
    {
        private int num;
        public DummyService()
        {
            num = new Random().Next(100, 200);
        }
        public int GetNumber()
        {
            return num;
        }
    }
}
