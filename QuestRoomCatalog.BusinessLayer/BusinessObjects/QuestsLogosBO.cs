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
        private IMapper mapper;

        public int Id { get; set; }
        public int QuestRoomId { get; set; }
        //public byte[] Image { get; set; }
        public bool IsLogo { get; set; }
        public virtual QuestsRoomsBO QuestsRooms { get; set; }
        public QuestsLogosBO() {}
        public QuestsLogosBO(IMapper mapperParam)
        {
            mapper = mapperParam;
        }
        public IEnumerable<QuestsLogosBO> GetBOList()
        {
            List<QuestsLogosBO> questLogosBOList = new List<QuestsLogosBO>();
            using (var unitOfWork = UnitOfWorkFactory.Create())
            { questLogosBOList = unitOfWork.QLogosUowRepository.GetAll().Select(item => mapper.Map<QuestsLogosBO>(item)).ToList(); }
            return questLogosBOList;
        }
        public void Add(IUnitOfWork unitOfWork)
        {
            var questLogos = mapper.Map<QuestsLogos>(this);
            unitOfWork.QLogosUowRepository.Add(questLogos);
            unitOfWork.Save();
        }
        public void Save()
        {
            using (var unitOfWork = UnitOfWorkFactory.Create())
            {
                if (this.Id != 0)
                {
                }
                else
                {
                    Add(unitOfWork);
                }
            }
        }
    }
}