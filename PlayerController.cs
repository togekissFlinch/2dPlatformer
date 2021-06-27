using Godot;
using System;

public class PlayerController : KinematicBody2D
{
	
	public override void _Ready()
	{
		
	}

	public override void _Process(float delta)
	{
	  Vector2 velocity = new Vector2();
	  int speed = 200;
	  if (Input.IsActionPressed("ui_right"))
	  {
		velocity.x += speed;	
	  }
	  if (Input.IsActionPressed("ui_left"))
	  {
		velocity.x -= speed;	
	  }
	  if (Input.IsActionPressed("ui_down"))
	  {
		velocity.y += speed;	
	  }
	  if (Input.IsActionPressed("ui_up"))
	  {
		velocity.y -= speed;	
	  }
	  MoveAndSlide(velocity, Vector2.Up);
	}
}
