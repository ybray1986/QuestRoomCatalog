using AutoMapper;
using Ninject;
using Ninject.Activation;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestRoomCatalog.Infrastucture
{
    public class AutoMapperModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper>().ToMethod(AutoMapping);
        }

        private IMapper AutoMapping(IContext context)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.ConstructServicesUsing(t => context.Kernel.Get(t));
                cfg.AddProfile<MapperProfiles>();
            });
            return Mapper.Instance;
        }
    }
}