using OutSystems.ExternalLibraries.SDK;

namespace JWS_token_generator.structures
{
    [OSStructure(
        Description = ""
    )]
    public struct CustomClaim {
        [OSStructureField(
            DataType = OSDataType.Text,
            Description = "",
            IsMandatory = false,
            Length = 0
        )]
        public string Name;
        [OSStructureField(
            DataType = OSDataType.Text,
            Description = "",
            IsMandatory = false,
            Length = 0
        )]
        public string Value;
    }

    [OSStructure(
        Description = ""
    )]
    public struct TokenPayload {
        [OSStructureField(
            DataType = OSDataType.Text,
            Description = "",
            IsMandatory = false,
            Length = 0
        )]
        public string Audience;
        [OSStructureField(
            DataType = OSDataType.InferredFromDotNetType,
            Description = "",
            IsMandatory = false
        )]
        public CustomClaim CustomClaim;
        [OSStructureField(
            DataType = OSDataType.DateTime,
            Description = "",
            IsMandatory = false
        )]
        public DateTime ExpirationTime;
        [OSStructureField(
            DataType = OSDataType.DateTime,
            Description = "",
            IsMandatory = false
        )]
        public DateTime IssuedAt;
        [OSStructureField(
            DataType = OSDataType.Text,
            Description = "",
            IsMandatory = false,
            Length = 0
        )]
        public string Issuer;
        [OSStructureField(
            DataType = OSDataType.Text,
            Description = "",
            IsMandatory = false,
            Length = 0
        )]
        public string JWTId;
        [OSStructureField(
            DataType = OSDataType.DateTime,
            Description = "",
            IsMandatory = false
        )]
        public DateTime NotBefore;
        [OSStructureField(
            DataType = OSDataType.Text,
            Description = "",
            IsMandatory = false,
            Length = 0
        )]
        public string Subject;
    }

}