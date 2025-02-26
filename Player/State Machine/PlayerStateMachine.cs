using Godot;
using Godot.Collections;
using System;

public partial class PlayerStateMachine : StateMachine
{
    [Export]
    Label debugLabel;

    [Export]
    Player characterBody2D;

    public override void _Ready()
    {
        AnimationNodeStateMachinePlayback stateMachine = (AnimationNodeStateMachinePlayback)animationTree.Get("parameters/playback");
        Array<Node> states = GetChildren();
        foreach (var state in states)
        {
            State state1 = state as State;
            state1.animationStateMachine = stateMachine;
            state1.characterBody2D = characterBody2D;
            Add(state.Name, state1);

        }
        EnterState("Idle");

    }

    public override void _Process(double delta)
    {
        debugLabel.Text = CurrentState.Name;
        ExecuteProcess(delta);
    }

    public override void _PhysicsProcess(double delta)
    {
        ExecuteStatePhysics(delta);
    }

}
