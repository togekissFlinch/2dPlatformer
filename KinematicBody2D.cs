using Godot;
using System;

public class KinematicBody2D : Godot.KinematicBody2D
{
	private void _on_Player_body_entered(object body)
	{
		if (body is KinematicBody2D)
		{
			GetTree().ReloadCurrentScene();
		}
	}
}
