using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;


[DisallowMultipleComponent]
internal class PlayerManager : MonoBehaviour, IConvertGameObjectToEntity, IDeclareReferencedPrefabs
{
    public int ValueA;
    public float ValueB;
    public GameObject[] Characters;

    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        //dstManager.AddComponentData(entity, componentData);
    }

    public void DeclareReferencedPrefabs(List<GameObject> referencedPrefabs)
    {
        // GeneratedAuthoringComponentImplementation
        //     .AddReferencedPrefab(referencedPrefabs, PrefabC);
        // GeneratedAuthoringComponentImplementation
        //     .AddReferencedPrefab(referencedPrefabs, PrefabD);
    }
}