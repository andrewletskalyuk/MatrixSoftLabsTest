using Newtonsoft.Json;

namespace MatrixSoft.Api.Services;

public class HolidayService
{
    private readonly HttpClient _httpClient;

    public HolidayService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Holiday>> GetSwedishRedDays()
    {
        // TODO: get token to make a request and get needful information!!!
        var response = await _httpClient.GetAsync("https://www.googleapis.com/calendar/v3/calendars/en.swedish.official#holiday@group.v.calendar.google.com");
        response.EnsureSuccessStatusCode();
        var jsonResponse = await response.Content.ReadAsStringAsync();
        var holidays = JsonConvert.DeserializeObject<List<Holiday>>(jsonResponse);
        return holidays;
    }
}

public class Holiday
{
    [JsonProperty("date")]
    public string? Date { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }
}
