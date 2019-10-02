using AutoMapper;
using QuestRoomCatalog.BusinessLayer.BusinessObjects;
using QuestRoomCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRoomCatalog.Controllers
{
    public class QuestLogosController : Controller
    {
        IMapper mapper;
        public QuestLogosController( IMapper mapperParam)
        {
            mapper = mapperParam;
        }
        // GET: QuestLogos
        public ActionResult Index()
        {
            var QLBO = mapper.ServiceCtor.Invoke(typeof(QuestsLogosBO));
            var QuestLogosView = (QLBO as QuestsLogosBO).Add();/*.Select(t=>mapper.Map<QuestLogosViewModel>(t)).FirstOrDefault()*/;
            return View(QuestLogosView);
        }

        // GET: QuestLogos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestLogos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestLogos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestLogos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestLogos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: QuestLogos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestLogos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
