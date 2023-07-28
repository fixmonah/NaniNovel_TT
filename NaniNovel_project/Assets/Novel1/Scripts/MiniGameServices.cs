using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[InitializeAtRuntime]
public class MiniGameServices : IEngineService
{
    private readonly UIManager uIManager;

    public MiniGameServices(UIManager uIManager)
    {
        this.uIManager = uIManager;
    }

    public UniTask InitializeServiceAsync()
    {
        Debug.Log("Services is Run");
        return UniTask.CompletedTask;
    }

    public void DestroyService()
    {

    }
    public void ResetService()
    {
        
    }

    public async UniTask CloseMiniGame()
    {
        return;
    }
}
