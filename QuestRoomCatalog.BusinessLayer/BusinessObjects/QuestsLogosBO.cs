namespace QuestRoomCatalog.BusinessLayer.BusinessObjects
{
    using DataLayer;
    using System;
    using System.Collections.Generic;

    public class QuestsLogosBO
    {
        public int Id { get; set; }
        public int QuestRoomId { get; set; }
        public byte[] Image { get; set; }
        public bool IsLogo { get; set; }
        public virtual QuestsRoomsBO QuestsRooms { get; set; }
    }
}
