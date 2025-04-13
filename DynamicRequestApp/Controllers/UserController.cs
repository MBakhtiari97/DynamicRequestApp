using DynamicRequestApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace DynamicRequestApp.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllRecords()
    {
        return Ok("This is get");
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok($"This is get with id: {id}");
    }

    [HttpPost]
    public IActionResult SaveData(UserData userData)
    {
        return Ok("This is save with object");
    }

    [HttpPut]
    public IActionResult UpdateData(UserData userData)
    {
        return Ok("This is update with object");
    }

    [HttpPatch("PatchDataUsername")]
    public IActionResult PatchDataUsername(UserData userData)
    {
        return Ok("This is patch username");
    }

    [HttpPatch("PatchDataPassword")]
    public IActionResult PatchDataPassword(UserData userData)
    {
        return Ok("This is patch password");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteData(int id)
    {
        return Ok($"This is delete with id: {id}");
    }
}