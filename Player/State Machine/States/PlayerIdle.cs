using Godot;
using System;

public partial class PlayerIdle : State
{
    public override void Enter(State previous){
        animationStateMachine.Travel("idle");
    }

    public override void PhysicsProcess(double delta)
    {
		Vector2 direction = Input.GetVector("left", "right", "ui_up","ui_down");
        if(direction != Vector2.Zero){
                fsm.ChangeState("Walking", this);
        }
        if(Input.IsActionJustPressed("interact")){
            fsm.ChangeState("Interact");
        }
    }
}
