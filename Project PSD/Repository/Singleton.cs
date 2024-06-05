using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Repository
{
    public class Singleton
    {
        private static RAisoEntities1 instance = null;

        public static RAisoEntities1 GetInstance()
        {
            if (instance == null)
            {
                instance = new RAisoEntities1();
            }
            return instance;
        }

    }
}