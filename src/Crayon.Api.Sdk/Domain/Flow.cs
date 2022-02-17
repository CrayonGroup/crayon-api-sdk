namespace Crayon.Api.Sdk.Domain
{
    public enum Flow
    {
        AuthorizationCode = 0,
        Implicit = 1,
        ResourceOwner = 4,
        Other = 9999
    }
}