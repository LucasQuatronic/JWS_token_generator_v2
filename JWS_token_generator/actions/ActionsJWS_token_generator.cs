using JWS_token_generator.interfaces;
using JWS_token_generator.structures;

namespace JWS_token_generator.actions {
    public class ActionsJWS_token_generator : InterfaceJWS_token_generator {
        public ActionsJWS_token_generator() {

        }

        public void GenerateDetachedJWSToken(TokenPayload Payload, string RSAKeyPlain) {
            
        }

        public void ValidateDetachedJWSToken(string Payload, string PublicRSAKey, string Token) {
            
        }

    }
}