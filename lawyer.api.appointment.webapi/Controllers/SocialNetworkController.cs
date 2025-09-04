using lawyer.api.appointment.application.DTO;
using lawyer.api.appointment.application.UseCases.SocialNetwork.Create;
using lawyer.api.appointment.application.UseCases.SocialNetwork.Delete;
using lawyer.api.appointment.application.UseCases.SocialNetwork.GetAll;
using lawyer.api.appointment.application.UseCases.SocialNetwork.GetById;
using lawyer.api.appointment.application.UseCases.SocialNetwork.Update;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lawyer.api.appointment.webapi.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class SocialNetworkController : ControllerBase
{
    private readonly IMediator _mediator;

    public SocialNetworkController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<SocialNetworkDto>>> Get()
    {
        var entities = await _mediator.Send(new GetAllSocialNetworkQuery());
        return Ok(entities);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<SocialNetworkDto>> Get(Guid id)
    {
        var entity = await _mediator.Send(new GetByIdSocialNetworkQuery(id));
        return Ok(entity);
    }

    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Post([FromBody] CreateSocialNetworkCommand command)
    {
        var id = await _mediator.Send(command);
        var url = Url.Action(nameof(Get), new { id });
        return Created(url, id);
    }

    [HttpPut]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Put([FromBody] UpdateSocialNetworkCommand command)
    {
        if (command.Id == Guid.Empty)
            return BadRequest("The provided ID is not valid.");

        var updatedId = await _mediator.Send(command);
        return Ok(updatedId);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(204)]
    [ProducesResponseType(404)]
    public async Task<ActionResult> Delete(Guid id)
    {
        var command = new DeleteSocialNetworkCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}
