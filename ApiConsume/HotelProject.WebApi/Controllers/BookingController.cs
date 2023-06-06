using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBooking2Service _booking2Service;

        public BookingController(IBooking2Service booking2Service)
        {
            _booking2Service = booking2Service;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _booking2Service.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking2 booking)
        {
            _booking2Service.TInsert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _booking2Service.TGetByID(id);
            _booking2Service.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking2 booking)
        {
            _booking2Service.TUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _booking2Service.TGetByID(id);
            return Ok(values);
        }
    }
}
