﻿using System;
using System.Collections.Generic;
using CommonDomain.Persistence;

namespace Inceptum.Cqrs
{
    public interface IEventStoreAdapter
    {
        void Bootstrap();
        Func<IRepository> Repository { get; }
        IEnumerable<object> GetEventsFrom(DateTime @from, params Type[] types);
    }
}