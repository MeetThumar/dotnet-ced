using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MNDcars.Controllers
{
    [ApiController]
    [Route("api/contact")]
    public class ContactController : ControllerBase
    {
        [HttpPost]
        public IActionResult SubmitContactForm([FromBody] ContactFormModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = "Invalid form submission." });

            // You can save form data to a database here (optional)
            return Ok(new { message = "Your message has been sent successfully!" });
        }
    }

    public class ContactFormModel
    {
        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
    }
}