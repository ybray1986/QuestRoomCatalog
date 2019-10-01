using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using QuestRoomCatalog.DataLayer.Repository;

namespace QuestRoomCatalog.DataLayer.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T: class
    {
        private readonly DbContext db;
        private bool disposed = false;

        Repository<T> _genericRepository;
        public UnitOfWork() { db = new Model1(); }
        public UnitOfWork(string connection)
        {
            db = new Model1(connection);
        }

        public Repository<T> GenericRepository
        {
            get
            {
                if (this._genericRepository == null)
                {
                    _genericRepository = new Repository<T>(db);
                }
                return _genericRepository;
            }
        }

        //public Repository<QuestsLogos> QLogosUowRepository
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //public Repository<QuestsRooms> QRoomsUowRepository
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //public Repository<Rating> RatingUowRepository
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //public Repository<Roles> RolesUowRepository
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        //public Repository<Users> UsersUowRepository
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        public void Save()
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                    if (db != null)
                    {
                        db.Dispose();
                    }
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~UnitOfWork() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            // GC.SuppressFinalize(this);
        }
        #endregion


    }
}