using QuestRoomCatalog.BusinessLayer.BusinessObjects;
using QuestRoomCatalog.DataLayer;
using QuestRoomCatalog.DataLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestRoomCatalog;

namespace QuestRoomCatalog.BusinessLayer
{
    class QuestLogosHelper
    {
        //Add construct with IMapper and UnitOfWork parameters

        IUnitOfWork<QuestsLogosBO> Db;
        QuestLogosHelper()
        {
            Db = new UnitOfWork<QuestsLogosBO>();
        }
        public void Create(QuestsLogosBO model)
        {
            //QuestsLogos questLogos = AutoMapper
            //Db.GenericRepository.Add(questLogos);
        }
    }
}
