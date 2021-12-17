using Unity.Entities;

[GenerateAuthoringComponent]
public class MapManagedComp : IComponentData
{
    public int[,] allCells;
}
