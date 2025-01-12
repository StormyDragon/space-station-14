﻿using Content.Shared.Roles;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.Roles;

public abstract partial class AntagonistRoleComponent : Component
{
    [DataField("prototype", required: true, customTypeSerializer: typeof(PrototypeIdSerializer<AntagPrototype>))]
    public string? PrototypeId;
}
