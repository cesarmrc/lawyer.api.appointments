using lawyer.api.appointments.application.DTO;
using lawyer.api.appointments.application.UseCases.Meeting.Create;
using lawyer.api.appointments.application.UseCases.Meeting.Delete;
using lawyer.api.appointments.application.UseCases.Meeting.GetAll;
using lawyer.api.appointments.application.UseCases.Meeting.GetById;
using lawyer.api.appointments.application.UseCases.Meeting.Update;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lawyer.api.appointments.webapi.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class MeetingController : ControllerBase
{
    private readonly IMediator _mediator;

    public MeetingController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<MeetingDto>>> Get()
    {
        var entities = await _mediator.Send(new GetAllMeetingQuery());
        return Ok(entities);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<MeetingDto>> Get(Guid id)
    {
        var entity = await _mediator.Send(new GetByIdMeetingQuery(id));
        return Ok(entity);
    }

    [HttpPost]
    [ProducesResponseType(201)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Post([FromBody] CreateMeetingCommand command)
    {
        var id = await _mediator.Send(command);
        var url = Url.Action(nameof(Get), new { id });
        return Created(url, id);
    }

    [HttpPut]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public async Task<ActionResult> Put([FromBody] UpdateMeetingCommand command)
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
        var command = new DeleteMeetingCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}
