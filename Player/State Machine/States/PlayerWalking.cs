using Godot;
using System;

public partial class PlayerWalking : State
{
    [Export]
    Sprite2D playerSprite;
    public const float Speed = 300.0f;
    Vector2 velocity;
	public override void Enter(State previous){
        animationStateMachine.Travel("walk");
    }

    public override void PhysicsProcess(double delta)
    {
        velocity = characterBody2D.Velocity;
        Vector2 direction = Input.GetVector("left", "right", "ui_up", "ui_down");
        if(direction.X < 0){
            playerSprite.FlipH = true;
        }else{
            playerSprite.FlipH = false;
        }
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(characterBody2D.Velocity.X, 0, Speed);
		}
        if(characterBody2D.Velocity.X == 0 && direction == Vector2.Zero){
            fsm.ChangeState("Idle", this);
        }

        if(Input.IsActionJustPressed("interact")){
            fsm.ChangeState("Interact");
        }

        characterBody2D.Velocity = velocity;
    }

    public override void Exit()
    {
        velocity = Vector2.Zero;
        characterBody2D.Velocity = velocity;
    }
}


