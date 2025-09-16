using System.Security.Claims;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuizController : ControllerBase
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _config;

    public QuizController(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient;
        _config = config;
    }

    [HttpPost("generate")]
    public async Task<IActionResult> GenerateQuiz([FromBody] string topic)
    {
        var apiKey = "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"; // store key in appsettings.json or env var

        var payload = new
        {
            model = "deepseek/deepseek-r1:free",
            messages = new[]
            {
                new { role = "user", content = $"Generate 10 technical quiz questions about {topic} in JSON format..." }
            },
            temperature = 0.7
        };

        var request = new HttpRequestMessage(HttpMethod.Post, "https://openrouter.ai/api/v1/chat/completions")
        {
            Content = JsonContent.Create(payload)
        };
        request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);

        var response = await _httpClient.SendAsync(request);

        if (!response.IsSuccessStatusCode)
            return StatusCode((int)response.StatusCode, "OpenRouter request failed");

        var result = await response.Content.ReadAsStringAsync();
        return Ok(result);
    }
}
    