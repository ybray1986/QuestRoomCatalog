namespace QuestRoomCatalog.BusinessLayer.BusinessObjects
{
    using AutoMapper;
    using DataLayer;
    using DataLayer.UnityOfWork;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class QuestsLogosBO
    {
        public int Id { get; set; }
        public int QuestRoomId { get; set; }
        public byte[] Image { get; set; }
        public bool IsLogo { get; set; }
        public virtual QuestsRoomsBO QuestsRooms { get; set; }
        public QuestsLogosBO() { }
        public QuestsLogosBO(IMapper mapperParam)
        {
            mapper = mapperParam;
        }
        private IMapper mapper;
        public IEnumerable<QuestsLogosBO> Add()
        {
            List<QuestsLogosBO> questLogosList = new List<QuestsLogosBO>();
            using (var unitOfWork = UnitOfWorkFactory.Create())
            { questLogosList = unitOfWork.QLogosUowRepository.GetAll().Select(item => mapper.Map<QuestsLogosBO>(item)).ToList(); }
            return questLogosList;
        }
    }
}
