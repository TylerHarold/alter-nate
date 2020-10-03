﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameState state;

    private UIManager UI;
    private GameInput game;
    private Dialogue dialogue;
    private Pause pause;
    private Puzzle puzzle;


    public enum GameState
    {
        UI,
        GAME,
        DIALOGUE,
        PAUSE,
        PUZZLE
    }


}