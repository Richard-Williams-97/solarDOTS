using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]
public struct EntityDynamicBuffer : IBufferElementData {
     // These implicit conversions are optional, but can help reduce typing.
    public static implicit operator Entity(EntityDynamicBuffer e) { return e.structure; }
    public static implicit operator EntityDynamicBuffer(Entity e) { return new EntityDynamicBuffer { structure = e }; }
    public Entity structure;
}