class ApiService(HttpClient http)
{
    public Task<string> GetItemAsync() => http.GetStringAsync("item");

    
}