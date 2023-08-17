using Microsoft.AspNetCore.Mvc;
using DemoAloMundoRest.DTOs;

namespace DemoAloMundoRest.Contrellers;

[ApiController]
[Route("[controller]")] 
public class AloMundoController : ControllerBase
{
    private readonly ILogger<AloMundoController> _logger;
    
    public AloMundoController(ILogger<AloMundoController>   logger)
    {
        _logger = logger;
    }
    
    // GET .../alomundo
     [HttpGet]

     public string Get()
     {
        _logger.LogInformation("GET /alomundo");
        return "Alô, Mundo!";
     }

      // GET .../alomundo/veronica

    [HttpGet("{nome}")]

    public string Get(string nome)
    {
        _logger.LogInformation("GET /alomundo/{nome}");
        return $"Alô, {nome}!";
    }

    // GET .../alomundo/query?nome=veronica
    [HttpGet("query")]
    public string GetQuery(string nome)
    {
        _logger.LogInformation("GET /alomundo/{nome}");
        return $"Alô, {nome}!";
    }

    // POST .../alomundo
    [HttpPost]

    public string Post([FromBody]string nome)
    {
        _logger.LogInformation("POST /alomundo/{nome}");
        return $"Alô, {nome}!";
    }

    // POST .../alomundo/pessoa
    [HttpPost("pessoa")]

    public string Post(Pessoa umaPessoa)
    {
        _logger.LogInformation("POST /alomundo/pessoa");
        _logger.LogInformation($"umaPessoa.nome = {umaPessoa.Nome}");
        _logger.LogInformation($"umaPessoa.idade = {umaPessoa.Idade}");
        return $"Alô, {umaPessoa.Nome}!";
    }

}