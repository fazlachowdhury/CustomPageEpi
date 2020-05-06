using EPiServer.Core;

namespace EPICodingChallenge.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
