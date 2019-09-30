namespace QuestRoomCatalog.BusinessLayer.BusinessObjects
{
    using System;
    using System.Collections.Generic;

    public class UsersBO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int RoleId { get; set; }
        public virtual RolesBO Roles { get; set; }
    }
}
