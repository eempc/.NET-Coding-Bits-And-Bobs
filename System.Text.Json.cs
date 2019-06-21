// https://devblogs.microsoft.com/dotnet/try-the-new-system-text-json-apis/?utm_source=vs_developer_news&utm_medium=referral

using (JsonDocument document = JsonDocument.Parse(json, options)) {
  foreach (JsonElement element in document.RootElement.EnumerateArray()) {
    int temp = element.GetProperty("temp").GetInt32();
  }  
}
