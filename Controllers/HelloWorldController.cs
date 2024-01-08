
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]


public class HelloWorldController : Controller
{
    public string sample = "Hello, Kyle";

    [HttpGet]
    [Route("Hello")]
    public string GetStudents()
    {
        return sample;
    }

    [HttpPost]
    [Route("HelloStudent/{studentName}")]
    public string AddStudent(string studentName)
    {
        return "Hello, " + studentName;
    }

}
