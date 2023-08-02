using Naninovel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

[InitializeAtRuntime]
public class MiniGameServices : IEngineService
{
    private readonly CustomVariableManager customVariableManager;

    public MiniGameServices(CustomVariableManager customVariableManager)
    {
        this.customVariableManager = customVariableManager;
    }

    public UniTask InitializeServiceAsync()
    {
        return UniTask.CompletedTask;
    }

    public void DestroyService() { }
    public void ResetService() { }

    public async UniTask OpenMiniGame()
    {
        await SceneManager.LoadSceneAsync("MiniGameMemory");
        customVariableManager.SetVariableValue("questState", "3");
        return;
    }

    public async UniTask CloseMiniGame()
    {
        await SceneManager.LoadSceneAsync("NovelScene");
        //Debug.Log("CloseMiniGame Services");
        return;
    }
}
