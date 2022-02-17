
namespace Crayon.Api.Sdk.Domain
{
    public enum ProductContainerCommentType
    {
        None = 0,
        Comment = 1,
        DraftCreated = 2,
        DraftModified = 4,
        QuoteCreated = 8,
        QuoteModified = 16,
        RequestCreated = 32,
        RequestModifed = 64,
        OrderSubmitted = 128,
        OrderInvoiced = 256,
        Removed = 512,
        TemplateCreated = 1024,
        TemplateModifed = 2048,
        RequestDeclined = 4096,

        SystemMessage =
            DraftCreated |
            DraftModified |
            QuoteCreated |
            QuoteModified |
            RequestCreated |
            RequestModifed |
            OrderSubmitted |
            OrderInvoiced |
            Removed |
            TemplateCreated |
            TemplateModifed |
            RequestDeclined
    }
}
