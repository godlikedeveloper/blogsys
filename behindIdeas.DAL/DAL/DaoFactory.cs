<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behindIdeas.DAL.DAL
{
    public class DaoFactory<T> where T : class,new()
    {

        public static T t = null;
        public static T GetInstance()
        {
            t = new T();
            return t;

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behindIdeas.DAL.DAL
{
    public class DaoFactory<T> where T : class,new()
    {

        public static T t = null;
        public static T GetInstance()
        {
            t = new T();
            return t;

        }
    }
}
>>>>>>> 2023c2e18ae698f405a9c4afacf6e82fa329710c
