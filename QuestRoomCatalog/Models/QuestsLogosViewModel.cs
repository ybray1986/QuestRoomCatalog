namespace QuestRoomCatalog.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class QuestLogosViewModel
    {
        public int Id { get; set; }
        public int QuestRoomId { get; set; }
        [Required]
        public byte[] Image { get; set; }
        public bool IsLogo { get; set; }
        //public virtual QuestsRoomsBO QuestsRooms { get; set; }
    }
}
