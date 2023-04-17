using System;
using System.Collections;
using System.Collections.Generic;

namespace InitInNetstandard2
{
    // Note init (C#9) also nullability annotation on reference type. The required (C#11) keyword is not really workable this way.
    public record Record
    {
        public string? Data { get; init; }
        public IEnumerable<int>? RandomUntypedIds { get; init; }
    }
}