using System;
using System.Collections.Generic;
using System.Text;

namespace agentsvsagentic
{
    public class WriterAgent
    {
        private readonly GroqClient _groq;

        public WriterAgent(GroqClient groq)
        {
            _groq = groq;
        }

        public async Task<string> RunAsync(string input)
        {
            return await _groq.ChatAsync(
                "You are a writer. Convert the content into a simple explanation.",
                input
            );
        }
    }
}
