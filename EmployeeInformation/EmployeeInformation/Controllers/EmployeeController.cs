﻿using EmpDetails;
using EmployeeInformation.Models;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EmployeeInformation.Controllers
{
    public class EmployeeController : Controller
    {
        EmpBlobOperations blobOperations;
        EmpTableOperations tableOperations;

        public EmployeeController()
        {
            blobOperations = new EmpBlobOperations();
            tableOperations = new EmpTableOperations();
        }
        // GET: Employee
        public ActionResult Index()
        {
            var details = tableOperations.GetEntities();
            return View(details);
        }
        public ActionResult Create()
        {
            var Details = new EmpDetailsClass();
            Details.RowKey = new Random().Next().ToString();
            return View(Details);
        }
        /// <summary>
        /// Edit function
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="profileFile"></param>
        /// <returns></returns>
        /// 
        /*public ActionResult Edit(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            EmpDetailsClass empDetailsClass = db.
            return View();
        }*/

            public ActionResult Details()
        {
            return View();
        }

        public ActionResult Delete(EmpDetailsClass deleteEntity)

        {
            var details = tableOperations.DeleteEntity(deleteEntity);
            return View(details);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmpDetailsClass obj, HttpPostedFileBase profileFile)
        {
            CloudBlockBlob profileBlob = null;
            //Step 1: Uploaded File in BLob Storage
            if (profileFile != null && profileFile.ContentLength != 0)
            {
                profileBlob = await blobOperations.UploadBlob(profileFile, obj.RowKey);
                obj.ProfileImage = profileBlob.Uri.ToString();
            }
            //Step 2: Save the Information in the Table Storage
            tableOperations.CreateEntity(obj);
            return RedirectToAction("Index");
        }
    }
}
