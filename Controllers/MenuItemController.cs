using MenuItemListing.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   
                new MenuItem() {Id=1, Name="Dosa", freeDelivery=false, Price=40, dateOfLaunch=new DateTime(2022,06,07),Active=true },
                new MenuItem() {Id=2, Name="Chapathi", freeDelivery=false,Price=20,dateOfLaunch=new DateTime(2022,06,08),Active=false},
                new MenuItem() {Id=2, Name="Idly", freeDelivery=false, Price=10,Active=false, dateOfLaunch=new DateTime(2022,06,09)}
            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {
                new MenuItem() {Id=1, Name="Dosa", freeDelivery=false, Price=40, dateOfLaunch=new DateTime(2022,06,07),Active=true },
                new MenuItem() {Id=2, Name="Chapathi", freeDelivery=false,Price=20,dateOfLaunch=new DateTime(2022,06,08),Active=false},
                new MenuItem() {Id=2, Name="Idly", freeDelivery=false, Price=10,Active=false, dateOfLaunch=new DateTime(2022,06,09)}

            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;


        }
    }

}