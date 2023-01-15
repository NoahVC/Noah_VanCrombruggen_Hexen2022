using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameSystem.States
{
    public class EndGameState : GameStateBase
    {
        public override void EndGame()
        {
            Time.timeScale = 0f;
            StateMachine.MoveTo(GameStates.End);
        }
    }
}
