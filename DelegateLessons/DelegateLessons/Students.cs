﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateLessons
{
    public delegate void MethodContainer();
    class Students 
    {
        public event MethodContainer onCount;
        public void Move(int distance)
        {
            for(int i = 1; i<=distance; i++)
            {
                Thread.Sleep(1000);
                if(i ==5)
                {
                    onCount();
                }
            }
        }
        



    }
}
