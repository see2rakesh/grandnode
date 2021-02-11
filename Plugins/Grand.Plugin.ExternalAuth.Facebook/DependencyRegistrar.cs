﻿using Grand.Core.Configuration;
using Grand.Core.DependencyInjection;
using Grand.Core.TypeFinders;
using Microsoft.Extensions.DependencyInjection;

namespace Grand.Plugin.ExternalAuth.Facebook
{
    public class DependencyInjection : IDependencyInjection
    {
        public virtual void Register(IServiceCollection serviceCollection, ITypeFinder typeFinder, GrandConfig config)
        {
            serviceCollection.AddScoped<FacebookAuthenticationMethod>();
        }

        public int Order {
            get { return 10; }
        }
    }

}
