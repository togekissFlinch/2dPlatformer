using Godot;
using System;

public class Node2D : Godot.Node2D
{
	private void _on_Area2D_body_entered(object body)
	{
		if (body is KinematicBody2D)
		{
			GetTree().ReloadCurrentScene();
		}
	}
}
