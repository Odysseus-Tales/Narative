using System;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text txtComponent;
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
        ManageState();
    }

    private void ManageState()
    {
        var nextState = state.GetNextState();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextState[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextState[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextState[2];
        }

        txtComponent.text = state.GetStateStory();
    } // ManageState
}  // AdventureGame
