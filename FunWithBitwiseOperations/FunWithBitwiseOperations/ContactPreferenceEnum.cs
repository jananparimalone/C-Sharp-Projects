﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithBitwiseOperations
{
    [Flags]
    public enum ContactPreferenceEnum
    {
        None = 1,
        Email = 2,
        Phone = 4,
        Text = 5,
        Ponyexpress = 6
    }
}
