using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Vendorproject.Models;

namespace Vendorproject.Controllers
{
    public class VendorController : Controller
    {
        // registration action
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        //registration post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind(Exclude = "IsEmailVerified,ActivationCode")]Vendorreg user)
        {
            bool status = false;
            string message = "";
            if(ModelState.IsValid)
            {

                #region  //email is already exist
                var isexist = IsEmailExist(user.Email);
                if(isexist)
                {
                    ModelState.AddModelError("EmailExist", "Email already exist");
                    return View(user);
                }
                #endregion

                #region Generate Activation code
                user.ActivationCode = Guid.NewGuid();
                #endregion

                #region Password Hashing
                user.Password = Crypto.Hash(user.Password);
                user.ConfirmPassword = Crypto.Hash(user.ConfirmPassword); //password hashing
                #endregion

                user.IsEmailVerified = false;
                #region Save To Database
                using (vendorEntities vc = new vendorEntities())
                {
                    vc.Vendorregs.Add(user);
                    vc.SaveChanges();


                    //send email to user
                    SendVerficationLinkEmail(user.Email, user.ActivationCode.ToString());
                    message = "Registration successfully done. account activation" +
                        "link has been sent to your email id:" + user.Email;
                    status = true;
                }
                #endregion



            }
            else
            {
                message = "invalid Request";
            }



            ViewBag.Message = message;
            ViewBag.Status = status;
            return View(user);
        }


        //verify Email

        //verifyemaillink

        //login

        //loginpost

        //logout
       [NonAction]
       public bool IsEmailExist(string Email)
        {
            using(vendorEntities vc = new vendorEntities())
            {
                var v = vc.Vendorregs.Where(a => a.Email == Email).FirstOrDefault();
                return v != null;
            }
        }


        [NonAction]
        public void SendVerficationLinkEmail(string email,string activationcode)
        {
            var verifyUrl = "/vendorreg/VerifyAccount/" + activationcode;
            var link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);
            var fromEmail = new MailAddress("dileeprockon007@gmail.com", "dileep suggala");
            var toEmail = new MailAddress(email);
            var fromEmailPassword = "@2317padma";
            string subject = "Your account is successfully created";

            string body = "<br/><br/>we are excited to tell you that yor vendor account is successfully created." +
                " Please click on below link to verify your account" +
                " <br/><br/><a href='" + link + "'>" + link + "</a>";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
            };
            using (var message = new MailMessage(fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
                smtp.Send(message);
        }


    }

    
}