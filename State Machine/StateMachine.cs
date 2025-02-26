using System.Collections.Generic;
using Godot;

public class StateMachine
    {
		[Export]
        protected Dictionary<string, State> states = new Dictionary<string, State>();
		[Export]
        public State CurrentState {get; private set;}
        public string CurrentStateName {get; private set;}
        public string previousStateName {get; set;}

        public void Add(string key, State state)
        {
            states[key] = state;
            state.fsm = this;
        }

        public void ExecuteStatePhysics(float delta) => CurrentState.PhysicsProcess(delta);
        public void ExecuteProcess(float delta) => CurrentState.Process(delta);

        public void EnterState(string newState) 
        {
            CurrentState = states[newState];
            CurrentStateName = newState;
            CurrentState.Enter();
        }

        public void ChangeState(string newState, State previous = null)
        {
            CurrentState.Exit();
            CurrentState = states[newState];
            CurrentStateName = newState;
            CurrentState.Enter(previous);
        }
    }