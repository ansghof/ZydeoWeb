﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZD.Common
{
    public interface IBinSerializable
    {
        void Serialize(BinWriter bw);
    }
}
