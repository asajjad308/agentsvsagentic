# Agents vs Agentic

A .NET 10 demonstration project showcasing the difference between **multi-agent systems** and **agentic workflows** using the Groq AI API.

## Overview

This project implements a simple multi-agent workflow where specialized agents collaborate to process tasks:

- **Manager Agent**: Orchestrates the workflow between agents
- **Research Agent**: Extracts and analyzes key concepts from input
- **Writer Agent**: Transforms research into simple, clear explanations

## Architecture

The system uses a pipeline architecture where:
1. The Manager receives a task
2. The Research Agent processes the task to extract key concepts
3. The Writer Agent converts the research into a simple explanation
4. The final result is returned

```
User Input → Manager Agent → Research Agent → Writer Agent → Output
```

## Prerequisites

- .NET 10 SDK
- Groq API key

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/asajjad308/agentsvsagentic.git
cd agentsvsagentic
```

### 2. Set up your API key

Replace the placeholder API key in `Program.cs`:

```csharp
var apiKey = "your_groq_api_key_here";
```

### 3. Run the application

```bash
dotnet run
```

## Usage

The main entry point demonstrates how to use the multi-agent system:

```csharp
var groq = new GroqClient(apiKey);
var manager = new ManagerAgent(groq);

var result = await manager.RunAsync("Explain microservices in simple terms");
Console.WriteLine(result);
```

## Project Structure

```
agentsvsagentic/
├── Program.cs           # Entry point
├── GroqClient.cs        # API client for Groq
├── ManagerAgent.cs      # Orchestration agent
├── ResearchAgent.cs     # Research specialist
├── WriterAgent.cs       # Writing specialist
└── agentsvsagentic.csproj
```

## Components

### GroqClient
Handles communication with the Groq API for AI interactions.

### ManagerAgent
Coordinates the workflow between the Research and Writer agents.

### ResearchAgent
Specializes in extracting and analyzing key concepts from input.

### WriterAgent
Converts research output into simple, understandable explanations.

## Dependencies

- `Microsoft.Agents.AI.Foundry` (v1.0.0)(for upcoming versions)

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is open source. Please check the repository for license details.

## Contact

For questions or feedback, please open an issue on the GitHub repository.
