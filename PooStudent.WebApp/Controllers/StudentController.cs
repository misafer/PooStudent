using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PooStudent.WebApp.Models;

namespace PooStudent.WebApp.Controllers
{
    public class StudentController : Controller
    {
        private Entities db = new Entities();

        // GET: Student/StudentIndex
        public ActionResult StudentIndex()
        {
            return View(db.Students.ToList());
        }

        /*
        // GET: Student/StudentDetails/5
        public ActionResult StudentDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }
        */

        // GET: Student/StudentCreate
        public ActionResult StudentCreate()
        {
            return View();
        }

        // POST: Student/StudentCreate
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StudentCreate([Bind(Include = "Id,StudentCode,Name,Family,Father,SSN,BirthDate,RegDate")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                DisplaySuccessMessage("Has append a Student record");
                return RedirectToAction("StudentIndex");
            }

            DisplayErrorMessage();
            return View(student);
        }

        // GET: Student/StudentEdit/5
        public ActionResult StudentEdit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: StudentStudent/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StudentEdit([Bind(Include = "Id,StudentCode,Name,Family,Father,SSN,BirthDate,RegDate")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                DisplaySuccessMessage("Has update a Student record");
                return RedirectToAction("StudentIndex");
            }
            DisplayErrorMessage();
            return View(student);
        }

        // GET: Student/StudentDelete/5
        public ActionResult StudentDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Student/StudentDelete/5
        [HttpPost, ActionName("StudentDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult StudentDeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            DisplaySuccessMessage("Has delete a Student record");
            return RedirectToAction("StudentIndex");
        }

        private void DisplaySuccessMessage(string msgText)
        {
            TempData["SuccessMessage"] = msgText;
        }

        private void DisplayErrorMessage()
        {
            TempData["ErrorMessage"] = "Save changes was unsuccessful.";
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
