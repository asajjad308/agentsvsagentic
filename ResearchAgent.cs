using System;
using System.Collections.Generic;
using System.Text;

namespace agentsvsagentic
{
    // ================= RESEARCH AGENT =================
    public class ResearchAgent
    {
        private readonly GroqClient _groq;

        public ResearchAgent(GroqClient groq)
        {
            _groq = groq;
        }

        public async Task<string> RunAsync(string input)
        {
            return await _groq.ChatAsync(
                "You are a research agent. Extract key concepts clearly.",
                input
            );
        }
    }
}
