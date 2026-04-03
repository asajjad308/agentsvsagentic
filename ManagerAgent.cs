using System;
using System.Collections.Generic;
using System.Text;

namespace agentsvsagentic
{
    // ================= MANAGER AGENT =================
    public class ManagerAgent
    {
        private readonly GroqClient _groq;

        public ManagerAgent(GroqClient groq)
        {
            _groq = groq;
        }

        public async Task<string> RunAsync(string task)
        {
            // Step 1: Research Agent
            var researchAgent = new ResearchAgent(_groq);
            var research = await researchAgent.RunAsync(task);

            // Step 2: Writer Agent
            var writerAgent = new WriterAgent(_groq);
            var final = await writerAgent.RunAsync(research);

            return final;
        }
    }
}
