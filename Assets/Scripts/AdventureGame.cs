﻿using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField]  Text txtComponent;
    [SerializeField] State startingState;

    // our current state
    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        txtComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
