using Unity.Entities;
using Unity.Mathematics;
using Unity.Collections;
using Unity.Burst;

[GenerateAuthoringComponent]
public struct MapAuthoringComp : IComponentData
{
    public EntityDynamicBuffer threes;
    public int2 InitialGridSize;
    public Entity FloorTile;
    public float2 CellSize;
    public float2 CellOffset;
    public float2 CellPadding;

    public int CellCount => InitialGridSize.x * InitialGridSize.y;
}
