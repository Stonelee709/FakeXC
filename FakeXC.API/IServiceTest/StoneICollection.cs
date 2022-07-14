using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXC.API.IServiceTest
{
    public static class StoneICollection
    {
        public static void AddStone(this IServiceCollection serviceCollection,Action<Stone> StoneAction)
        {
            Stone stone = new Stone();
            StoneAction(stone);
            serviceCollection.AddSingleton<IStone>(stone);
        }
    }
}
