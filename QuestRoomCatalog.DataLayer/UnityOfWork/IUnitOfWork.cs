using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuestRoomCatalog.DataLayer.Repository;

namespace QuestRoomCatalog.DataLayer.UnityOfWork
{
    public interface IUnitOfWork : IDisposable /*where T: class*/
    {
        Repository<Roles> RolesUowRepository { get; }
        Repository<Rating> RatingUowRepository { get; }
        Repository<Users> UsersUowRepository { get; }
        Repository<QuestsLogos> QLogosUowRepository { get; }
        Repository<QuestsRooms> QRoomsUowRepository { get; }
        //Repository<T> GenericRepository { get; }

        void Save();


    }
}