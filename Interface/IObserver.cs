﻿using Labb_1_Marcus_Hellkvist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1_Marcus_Hellkvist.Interface
{
    public interface IObserver
    {
        void Update(ISubject subject, int flag);
    }
}
