using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domen.DAL;
using Domen.Entities;

namespace SimpleOnlineStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly UnituOfWork unitOfWork;

        public OrderController()
        {
            this.unitOfWork = new UnituOfWork();
        }

        public ActionResult Index()
        {
            IEnumerable<Order> orders = unitOfWork.OrderRepository.Get();
            return View(orders);
        }

        public ActionResult Details(int id)
        {
            OrderLine orderLine = unitOfWork.OrderLineRepository.GetByID(id);
            return View(orderLine);
        }
    }
}
