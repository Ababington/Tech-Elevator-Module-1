using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
       
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        [HttpGet]

        public List<Auction> ListAuctions(string title_like = "", double currentBid_lte = 0)
        {
            if (title_like != "" && currentBid_lte != 0)
            {
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }
            if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            if (currentBid_lte != 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }
                return dao.List();
            
        }
        [HttpGet("{id}")]
        public Auction GetAuctions(int id)
        {
            Auction auction = dao.Get(id);

            if (auction != null)
            {
                return auction;
            }

            return null;
        }

        [HttpPost]
        public Auction AddReservation(Auction auction)
        {
            Auction output = dao.Create(auction);
            return output;
        }
    }
}
