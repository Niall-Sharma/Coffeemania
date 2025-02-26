using Godot;
using System;

public partial class PlayerInteract : State
{
	public override void Enter(State state){
		animationStateMachine.Travel("interact");
	}

    public override void Process(double delta)
    {
        if(Input.IsActionJustReleased("interact")){
			fsm.ChangeState("Idle");
		}
    }
}
