//
//
//
//Peer Review: by Christopher Prado 25OCT22 , your APIinput for MiniChallenge 2 runs effectively. I think its awesome how I can add any 2 number together and it's connected to the local host 





using Microsoft.AspNetCore.Mvc;

namespace TupasKAddingNumbersAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AddingNumbersController : ControllerBase
{
[HttpGet]
[Route("Adding/{numberone}/{numbertwo}")]

public int Adding(string numberone, string numbertwo)
{
int num1 = Convert.ToInt32(numberone);
int num2 = Convert.ToInt32(numbertwo);
return num1 + num2;
}
}


