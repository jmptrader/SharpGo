﻿namespace SharpGo.Core.Compiler
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public enum TokenType
    {
        Name,
        Integer,
        Real,
        String,
        Operator,
        Delimiter,
        NewLine
    }
}
