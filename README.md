# SnakeCaseJson

## References and Related Articles

[Custom Naming Policy for JSON in C# - Code Maze](https://code-maze.com/csharp-custom-naming-policy-for-json/)

> ## New Features in .NET 8 JSON Naming Policy
>
> **As of the writing of this article, Microsoft released .NET 8 which adds new, popular naming conventions to the `JsonNamingPolicy` class.** If we look at the [Microsoft documentation](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonnamingpolicy?view=net-8.0#properties) we see we have five static properties:
>
> - CamelCase provides a “camelCase” policy (in .NET Core 3.0 and higher)
> - KebabCaseLower provides a “kebab-case-lower” policy (new in .NET 8)
> - KebabCaseUpper provides a “Kebab-Case-Upper” policy (new in .NET 8)
> - SnakeCaseLower provides a “snake\_case\_lower” policy (new in .NET 8)
> - SnakeCaseUpper provides a “Snake\_Case\_Upper” policy (new in .NET 8)
>
> The kebab cases use a dash (-) between words and have upper- and lowercase variations, whereas the snake cases use an underscore (\_) between words and also have upper- and lowercase variations.
>
> Since these are static properties we can assign them directly to the `PropertyNamingPolicy` property:
>
> ```csharp
> var snakeCaseLowerPolicy = new JsonSerializerOptions
> {
>   PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
> };
> ```
>
> If we use this with our `person` object from earlier, we see the properties formatted as snake-case:
>
> ```json
> { "given_name": "Name1", "sur_name": "Surname1" }
> ```

[JsonNamingPolicy Class (System.Text.Json) | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonnamingpolicy?view=net-8.0#properties)

> | Naming Policy                                                                                          | Description                                      |
> |--------------------------------------------------------------------------------------------------------|--------------------------------------------------|
> | [CamelCase](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonnamingpolicy.camelcase?view=net-8.0#system-text-json-jsonnamingpolicy-camelcase) | Gets the naming policy for camel-casing.         |
> | [KebabCaseLower](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonnamingpolicy.kebabcaselower?view=net-8.0#system-text-json-jsonnamingpolicy-kebabcaselower) | Gets the naming policy for lowercase kebab-casing. |
> | [KebabCaseUpper](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonnamingpolicy.kebabcaseupper?view=net-8.0#system-text-json-jsonnamingpolicy-kebabcaseupper) | Gets the naming policy for uppercase kebab-casing. |
> | [SnakeCaseLower](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonnamingpolicy.snakecaselower?view=net-8.0#system-text-json-jsonnamingpolicy-snakecaselower) | Gets the naming policy for lowercase snake-casing. |
> | [SnakeCaseUpper](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonnamingpolicy.snakecaseupper?view=net-8.0#system-text-json-jsonnamingpolicy-snakecaseupper) | Gets the naming policy for uppercase snake-casing. |

[System.Text.Json snakecase :: michaelrose.dev — Michael's blog](https://www.michaelrose.dev/posts/exploring-system-text-json/)

[Snake-casing JSON requests and responses with ASP.NET Core and System.Text.Json | CodeBork Tales from the Codeface](https://codebork.com/2021/02/14/Snake-casing-JSON-requests-and-responses-with-ASP.NET-Core-and-System.Text.Json.html)

[C# - Deserialize JSON using different property names | makolyte](https://makolyte.com/csharp-deserialize-json-using-different-property-names/)

> When JSON property names and class property names are different, and you can’t just change the names to match, you have three options:
>
> - Use the JsonPropertyName attribute.
> - Use a naming policy (built-in or custom).
> - A combination of these two. In other words, use JsonPropertyName for special cases that your naming policy doesn’t handle.
>
> These options affect both deserialization and serialization.
>
> Let’s say you have the following JSON with camel-cased property names:
>
> ```json
> {
>   "title": "Code",
>   "subtitle": "The Hidden Language of Computer Hardware and Software",
>   "authorName": "Charles Petzold",
>   "dateFirstPublished": "2000-10-11T00:00:00"
> }
> ```
>
> Here’s an example of using the JsonPropertyName attribute:
>
> ```csharp
> using System.Text.Json.Serialization;
> 
> public class Book
> {
>     [JsonPropertyName("title")]
>     public string Title { get; set; }
> 
>     [JsonPropertyName("subtitle")] 
>     public string Subtitle { get; set; } 
> 
>     [JsonPropertyName("authorName")] 
>     public string AuthorName { get; set; } 
> 
>     [JsonPropertyName("dateFirstPublished")] 
>     public DateTime DateFirstPublished { get; set; }
> }
> ```
>
> Note: The Newtonsoft equivalent is `[JsonProperty(“title”)]`
