using System.Collections;
using System.Collections.Generic;
using GameSystem;
using UnityEngine;
using Utils;

namespace GameSystem.States
{
    public class StartGameState : GameStateBase
    {
        public override void StartGame()
        {
            Time.timeScale = 1f;
            StateMachine.MoveTo(GameStates.Play);
        }
    }
}
