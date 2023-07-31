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
    private readonly StateManager stateManager;
    private readonly CustomVariableManager customVariableManager;
    private readonly ScriptManager scriptManager;

    public MiniGameServices(
        StateManager stateManager, 
        CustomVariableManager customVariableManager,
        ScriptManager scriptManager
        )
    {
        this.stateManager = stateManager;
        this.customVariableManager = customVariableManager;
        this.scriptManager = scriptManager;
    }

    public UniTask InitializeServiceAsync()
    {
        return UniTask.CompletedTask;
    }

    public void DestroyService()
    {

    }
    public void ResetService()
    {
        
    }

    public async UniTask OpenMiniGame()
    {
        await stateManager.SaveGameAsync("MiniGameSave");
        await SceneManager.LoadSceneAsync("MiniGameMemory");
        return;
    }

    public async UniTask CloseMiniGame()
    {
        await SceneManager.LoadSceneAsync("NovelScene");
        await stateManager.LoadGameAsync("MiniGameSave");
        customVariableManager.SetVariableValue("questState", "3");
        return;
    }
}
