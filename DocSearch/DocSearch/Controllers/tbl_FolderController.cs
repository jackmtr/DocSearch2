using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DocSearch.Models;

namespace DocSearch.Controllers
{
    public class tbl_FolderController : Controller
    {
        private WASEntities db = new WASEntities();

        // GET: tbl_Folder
        public async Task<ActionResult> Index()
        {
            var tbl_Folder = db.tbl_Folder.Include(t => t.tbl_Cabinet);
            return View(await tbl_Folder.ToListAsync());
        }

        // GET: tbl_Folder/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Folder tbl_Folder = await db.tbl_Folder.FindAsync(id);
            if (tbl_Folder == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Folder);
        }

        // GET: tbl_Folder/Create
        public ActionResult Create()
        {
            ViewBag.Cabinet_ID = new SelectList(db.tbl_Cabinet, "Cabinet_ID", "Name");
            return View();
        }

        // POST: tbl_Folder/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Folder_ID,Cabinet_ID,Name,Number,Security,LastUser_DT")] tbl_Folder tbl_Folder)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Folder.Add(tbl_Folder);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Cabinet_ID = new SelectList(db.tbl_Cabinet, "Cabinet_ID", "Name", tbl_Folder.Cabinet_ID);
            return View(tbl_Folder);
        }

        // GET: tbl_Folder/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Folder tbl_Folder = await db.tbl_Folder.FindAsync(id);
            if (tbl_Folder == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cabinet_ID = new SelectList(db.tbl_Cabinet, "Cabinet_ID", "Name", tbl_Folder.Cabinet_ID);
            return View(tbl_Folder);
        }

        // POST: tbl_Folder/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Folder_ID,Cabinet_ID,Name,Number,Security,LastUser_DT")] tbl_Folder tbl_Folder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Folder).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Cabinet_ID = new SelectList(db.tbl_Cabinet, "Cabinet_ID", "Name", tbl_Folder.Cabinet_ID);
            return View(tbl_Folder);
        }

        // GET: tbl_Folder/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_Folder tbl_Folder = await db.tbl_Folder.FindAsync(id);
            if (tbl_Folder == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Folder);
        }

        // POST: tbl_Folder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tbl_Folder tbl_Folder = await db.tbl_Folder.FindAsync(id);
            db.tbl_Folder.Remove(tbl_Folder);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
