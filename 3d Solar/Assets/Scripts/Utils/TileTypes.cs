using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct TileTypes{

    public enum Tiles{
        
        None,
        All,
        Middle, 
        Corners,  
        CorRand,
        MidRand
    }

    public static int[] getType(Tiles type){

        switch(type){

            case Tiles.None :
                return new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0};
            
            case Tiles.All :
                return new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1};
            
            case Tiles.Middle :
                return new int[] {0, 0, 0, 0, 1, 0, 0, 0, 0};
            
            case Tiles.Corners :
                return new int[] {1, 0, 1, 0, 0, 0, 1, 0, 1};
            
            case Tiles.CorRand :
                return new int[] {rand(), 0, rand(), 0, 0, 0, rand(), 0, rand()};
                
            case Tiles.MidRand :
                return new int[] {0, 0, 0, 0, rand(), 0, 0, 0, 0};

            default : 
                return new int[] {0, 0, 0, 0, 0, 0, 0, 0, 0};

        }
    }

    public static int rand() {

        return new Unity.Mathematics.Random((uint)UnityEngine.Random.Range(0, 2)).NextInt();
    }
}