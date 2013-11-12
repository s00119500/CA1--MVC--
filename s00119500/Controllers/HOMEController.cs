using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace s00119500.Controllers
{
    public class HOMEController : Controller
    {
        musicDBDataContext mdb = new musicDBDataContext();
        // GET: /HOME/

        public ActionResult Index()
        {
            var queryDispalyOrdersFromAlbums = from order in mdb.Orders
                select order; // populate home page
            
            return View(queryDispalyOrdersFromAlbums);
        }

        public ActionResult DisplayAlbum()//int id
        {
            #region wrong
            //var getOrderDetailsId = from o in mdb.OrderDetails
            //    select o.OrderId;
            //var getOrderId = from d in mdb.Orders
            //    select d.OrderId;

            //string a = getOrderId.ToString();
            //string b = id.ToString();

            
            
            //if (a == b)
            //{
            //     TempData ["alertMessage"] =( "{0}", );
            //}
            #endregion

            return View();
        }//end disolay album

        private void PopulateDropdownMenu()
        {

        }//end Drop down


        public ActionResult SortOrderTableAscending()
        {
            IOrderedQueryable<Order> orderAscending = from o in mdb.Orders
                                                      orderby o.OrderDate ascending
                                                      select o;
            return View(orderAscending); //"Cannot resolve view" does this mean i have to make a new view?
        } //end SortOrderTableAscending

        public ActionResult SortOrderDescending()
        {
            IOrderedQueryable<Order> sortDescending = from o in mdb.Orders
                                                      orderby o.OrderDate descending
                                                      select o;
            return View(sortDescending);
        } //end SortOrderDescending

        public ActionResult SortViaTotalValue()
        {
            IOrderedQueryable<Order> sortViaTotalValue = from order in mdb.Orders
                orderby order.Total descending
                select order;
            return View(sortViaTotalValue);
        }// end SortViaTotalValue()

        public ActionResult SearchViaName()
        {
            //get names from database
            var searchDbUserName = from order in mdb.Orders
                select order.Username.ToString();
            var searchDbFirstName = from order in mdb.Orders
                                   select order.FirstName.ToString();
            var searchDbSecondName = from order in mdb.Orders
                                   select order.LastName.ToString();
            //get name from txtbx
            var txt = InputType.Text.ToString();
            //compare
            //if ()
            //{
            //    //display 
                return View();
            //}
            
            
        }//end search via name
        //public ActionResult Browse (){}

        //
        // GET: /HOME/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /HOME/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /HOME/Create

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

        //
        // GET: /HOME/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /HOME/Edit/5

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

        //
        // GET: /HOME/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /HOME/Delete/5

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
#region jquery alternative
//@*<script type="text/javascript">
//    var btn = $("#btnSubmit");
//    var txtbx = $("#txtbxSearchForOrder");
//    var dbUserName =  @foreach (var item in Model)
//                      {@Html.DisplayFor(modelItem => item.OrderDate);
//                      }
//    btn.click(function () {
//        if (btn.text == dbUserName) {

//        }//end if
//    });// click function
//</script>*@
#endregion
