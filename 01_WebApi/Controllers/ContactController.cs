using Application.Service.Interface;
using Application.ViewModel;
using Core.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebApi.Controllers;
[Route("api/v1/contacts")]
[ApiController]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Contact>>> GetAllAsync()
    {
        try
        {
            var contacts = await _contactService.GetAllAsync();
            return Ok(new ResultViewModel<IList<Contact>>(contacts));
        }
        catch (SystemException)
        {
            // 01X01 é um código único qualquer que facilita identificar onde o erro foi gerado (Uma boa prática)
            return StatusCode(500, new ResultViewModel<IList<Contact>>("01X01 - Internal server error")); 
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Contact>> GetByIdAsync(int id)
    {
        try
        {
            var contact = await _contactService.GetByIdAsync(id);

            if (contact is null)
                return NoContent();

            return Ok(new ResultViewModel<Contact>(contact));
        }
        catch
        {
            return StatusCode(500, new ResultViewModel<Contact>("01X02- Internal server error"));
        }
    }
}
