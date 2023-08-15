using System.Threading.Tasks;
using app.Commands;
using app.Entities;
using app.Notifications;
using app.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult> GetProducts()
    {
        var products = await _mediator.Send(new GetProductsQuery());
        return Ok(products);
    }

    [HttpPost]
    public async Task<ActionResult> AddProduct([FromBody] Product product)
    {
        var producToReturn = await _mediator.Send(new AddProductCommand(product));
        await _mediator.Publish(new ProductAddedNotification(producToReturn));
        return StatusCode(201);
    }
}