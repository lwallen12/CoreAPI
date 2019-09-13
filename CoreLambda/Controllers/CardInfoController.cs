using Clash;
using CoreLambda.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreLambda.Controllers
{
    [Route("api/cardinfo/")]
    [ApiController]
    public class CardInfoController : ControllerBase
    {
        private readonly ClashContext _context;


        private string Hello;

        public CardInfoController(ClashContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<CardInfo> GetCardInfo()
        {
            return _context.CardInfo;
        }

        // GET: api/CardInfoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCardInfo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cardInfo = await _context.CardInfo.FindAsync(id);

            if (cardInfo == null)
            {
                return NotFound();
            }

            return Ok(cardInfo);
        }


    }
}
