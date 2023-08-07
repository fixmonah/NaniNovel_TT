using Naninovel;
using Naninovel.UI;
using UnityEngine;

public class MiniGameCustomUIController : CustomUI
{
    MiniGameServices miniGameServices;
    [Header("MiniGame")]
    [SerializeField] PlayScript playScript;

    protected override void Awake()
    {
        base.Awake();
        miniGameServices = Engine.GetService<MiniGameServices>();
    }

    public void StartMiniGame()
    {
        UniTask gameOverTask = miniGameServices.OpenMiniGame();
        playScript.Play();
    }
}
