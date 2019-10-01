using AutoMapper;
using QuestRoomCatalog.BusinessLayer;
using QuestRoomCatalog.BusinessLayer.BusinessObjects;
using QuestRoomCatalog.DataLayer;
using QuestRoomCatalog.Models;

namespace QuestRoomCatalog.Infrastucture
{
    internal class MapperProfiles: Profile
    {
        public MapperProfiles()
        {
            this.CreateMap<QuestsLogos, QuestsLogosBO>();
            this.CreateMap<QuestsLogosBO, QuestLogosViewModel>();
            this.CreateMap<QuestLogosViewModel, QuestsLogosBO>();
            this.CreateMap<QuestsLogosBO, QuestsLogos>();

            //this.CreateMap<QuestLogosHelper, >
        }
    }
}