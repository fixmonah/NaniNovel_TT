using Naninovel;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class MiniGameReturnButton : MonoBehaviour
{
    MiniGameServices miniGameServices;

    protected void Awake()
    {
        miniGameServices = Engine.GetService<MiniGameServices>();
    }

    public void CloseMiniGame()
    {
        UniTask gameOverTask = miniGameServices.CloseMiniGame();
        //Debug.Log("CloseMiniGame Button");
    }
}
