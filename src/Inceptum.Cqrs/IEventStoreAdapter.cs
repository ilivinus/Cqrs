﻿using System;
using System.Collections.Generic;
using CommonDomain.Persistence;

namespace Inceptum.Cqrs
{
    internal interface IEventStoreAdapter
    {
        IRepository Repository { get; }
        IEnumerable<object> GetEventsFrom(DateTime @from, params Type[] types);
    }
}