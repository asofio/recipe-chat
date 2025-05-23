using System.Text.Json.Serialization;

namespace RecipeChat.PromptTemplates.Models
{
    public class AgentTerminationStrategyResponse
    {
        [JsonPropertyName("should_terminate")]
        public required bool ShouldTerminate { get; init; }

        [JsonPropertyName("termination_reason")]
        public required string TerminationReason { get; init; }
    }
}