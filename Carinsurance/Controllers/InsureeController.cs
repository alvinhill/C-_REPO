using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Carinsurance.Models;

namespace Carinsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index(string FirstName)
        {
           

            return View(db.Insurees.ToList());
        }

        





        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {



            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            //BASE RATE
            if (insuree.FirstName !="")
            {
                insuree.Quote += 50;
            }

            DateTime MARK_AGE = DateTime.Now;
            DateTime CUST_AGE = insuree.DateOfBirth;
            int x = 18;

            int y = 19;
            int z = 25;

            //// ARE THEY YOUNGER THAN 18
            if (CUST_AGE.AddYears(x) < MARK_AGE)
            {

               insuree.Quote += 100;
            }
            else if (CUST_AGE.AddYears(y) > MARK_AGE && CUST_AGE.AddYears(z) < MARK_AGE)
            {
                insuree.Quote += 77; // $25;
            }





            // ARE THEY BETWEEN 19 AND 26

            //DateTime MARK_AGE1 = DateTime.Now;
            //DateTime CUST_AGE1 = insuree.DateOfBirth;

            //if (CUST_AGE.AddYears(y) > MARK_AGE && CUST_AGE.AddYears(z) < MARK_AGE)
            //{
            //    insuree.Quote += 77; // $25;

            //}






            // 911 PORSCHE CARRERA CHARGE
            if (insuree.CarMake == "Porsche" && insuree.CarModel=="911 Carrera")
            {
                insuree.Quote += 50;
            }// PORSCHE MAKE only CHARGE
            else if( insuree.CarMake=="Porsche")
            {
                insuree.Quote += 25;
            }

            // SPEEDING TICKETS
            if (insuree.SpeedingTickets >0 )
                {
                insuree.Quote += (10*insuree.SpeedingTickets);
            }

            // CAR YEAR BEFOR 2000 OR AFTER 2015
            if (insuree.CarYear < 2000 || insuree.CarYear >2015)
            {
                insuree.Quote += 25;
            }

            // DUI
            if (insuree.DUI == true)
            {
                Double DUI_RATE = Convert.ToDouble(insuree.Quote);
                Double DUI_TOTAL = (.25 * DUI_RATE );
                insuree.Quote += Convert.ToInt32(DUI_TOTAL);
            }

            // FULL COVERAGE
            if (insuree.CoverageType == true)
            {
                Double COV_RATE = Convert.ToDouble(insuree.Quote);
                Double COV_TOTAL = (.5 * COV_RATE);
                insuree.Quote += Convert.ToInt32(COV_TOTAL);
            }





            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
           

            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }




        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
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
