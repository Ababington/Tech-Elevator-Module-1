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

        public AuctionsController(IAuctionDao auctionDao)
        {
            dao = auctionDao;
        }

        [HttpGet]
        public List<Auction> List(string title_like = "", double currentBid_lte = 0)
        {
            if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }

            return dao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Auction> Get(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
                return Ok(auction);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Auction> Create(Auction auction)
        {
            if (auction.Title == null)
            {
                return BadRequest();
            }
            Auction added = dao.Create(auction);
            return Created($"/reservations/{added.Id}", added);
        }

        [HttpPut("{id}")]
        public ActionResult<Auction> UpdateAuction(int id, Auction auction)
        {
            Auction existingAuction = dao.Get(id);
            if (auction.Title == "")
            {
                return BadRequest();
            }
            if (existingAuction == null)
            {
                return NotFound($"auction id {id} doesn't exist");
            }
            else
            {
                Auction result = dao.Update(id, auction);
                return Ok(result);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Auction> DeleteAuction(int id)
        {
            Auction existingReservation = dao.Get(id);
            if (existingReservation == null)
            {
                return NotFound($"auction id {id} doesn't exist");
            }
            dao.Delete(id);
           
            return NoContent();
                
        }


    }
}



