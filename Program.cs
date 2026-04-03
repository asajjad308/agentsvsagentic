using agentsvsagentic;

var apiKey = "api_key";
 
var groq = new GroqClient(apiKey);

// Manager orchestrates the workflow
var manager = new ManagerAgent(groq);

var result = await manager.RunAsync("Explain microservices in simple terms");

Console.WriteLine("\nFINAL OUTPUT:\n");
Console.WriteLine(result);