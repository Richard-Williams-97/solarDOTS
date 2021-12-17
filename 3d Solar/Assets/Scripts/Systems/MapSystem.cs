using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;


public class MapSystem : SystemBase {

    private MapAuthoringComp _mapAuthoringComp;
    private BeginInitializationEntityCommandBufferSystem ei_ECB;

    protected override void OnCreate() {
        ei_ECB = World.GetOrCreateSystem<BeginInitializationEntityCommandBufferSystem>();
    }
    protected override void OnUpdate()
    {

        var ecb = ei_ECB.CreateCommandBuffer();
        var _MapEntity = GetSingletonEntity<MapAuthoringComp>();
        _mapAuthoringComp = EntityManager.GetComponentData<MapAuthoringComp>(_MapEntity);


    }

}
