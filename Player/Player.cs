using Godot;
using System;

public partial class Player : CharacterBody2D
{
	PlayerStateMachine playerStateMachine;

	public override void _PhysicsProcess(double delta)
	{
		// Vector2 velocity = Velocity;

		// // Handle Jump.
		// if (Input.IsActionJustPressed("jump") && IsOnFloor())
		// {
		// 	velocity.Y = JumpVelocity;
		// }

		// // Get the input direction and handle the movement/deceleration.
		// // As good practice, you should replace UI actions with custom gameplay actions.
		// Vector2 direction = Input.GetVector("left", "right", "ui_up", "ui_down");
		// if (direction != Vector2.Zero)
		// {
		// 	velocity.X = direction.X * Speed;
		// }
		// else
		// {
		// 	velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
		// }

		// Velocity = velocity;

		MoveAndSlide();
	}
}
