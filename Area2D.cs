using Godot;
using System;

public class Area2D : Godot.Area2D
{
	private void _on_Player_body_entered(Godot.Object body)
	{
		GD.Print(body);
	}
}
