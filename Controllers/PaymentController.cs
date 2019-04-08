using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetProjectBackEnd.Models;
using DotNetProjectBackEnd.Models.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetProjectBackEnd.Controllers
{
    [Route("api/[controller]")]
    public class PaymentController : Controller
    {
        private IDataPayment<Payment, double> _iPayRepo;
        public PaymentController(IDataPayment<Payment, double> repo)
        {
            _iPayRepo = repo;
        }


        // POST api/<controller>
        [HttpPost]
        public double Post([FromBody]Payment value)
        {
            return _iPayRepo.CalculatePay(value);
        }

       
    }
}
