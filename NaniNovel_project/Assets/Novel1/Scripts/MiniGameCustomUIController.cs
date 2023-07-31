using Naninovel;
using Naninovel.UI;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using static Naninovel.Bridging.Serializer;
using static UnityEditor.Experimental.GraphView.Port;

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
