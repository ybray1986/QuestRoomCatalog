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
        public IEnumerable<QuestsLogosBO> Add()
        {
            List<QuestsLogosBO> bo = new List<QuestsLogosBO> {
                new QuestsLogosBO() {Id = 1, QuestRoomId = 1, IsLogo = true,  }
            };
            return bo;
        }
    }
}
