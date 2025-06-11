using OutSystems.ExternalLibraries.SDK;
using JWS_token_generator.structures;

namespace JWS_token_generator.interfaces
{
    [OSInterface(
        Name = "JWS_token_generator",
        Description = "Contains actions to create and validate Detached JWS tokens"
    )]
    public interface InterfaceJWS_token_generator
    {   
        [OSAction(
            Description = ""
        )]
        void GenerateDetachedJWSToken(TokenPayload Payload, string RSAKeyPlain);
        [OSAction(
            Description = ""
        )]
        void ValidateDetachedJWSToken(string Payload, string PublicRSAKey, string Token);
    }
}