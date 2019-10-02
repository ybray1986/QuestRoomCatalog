using QuestRoomCatalog.DataLayer.UnityOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace QuestRoomCatalog.DataLayer.UnityOfWork
{
    public class UnitOfWorkFactory
    {
        public static IUnitOfWork Create()
        {
            return new UnitOfWork(new Model1());
        }
    }
}
