using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Scenes;
using UnityEngine;

public class LoadSubscene : MonoBehaviour
{
    [SerializeField] private SubScene subScene;
    
    // Start is called before the first frame update
    void Start()
    {
        SceneSystem.LoadSceneAsync(
            World.DefaultGameObjectInjectionWorld.Unmanaged,
            subScene.SceneGUID
        );
    }
}
