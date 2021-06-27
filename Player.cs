using Godot;
using System;

public class Player : Area2D
{
	public override void _Process(float delta)
	{
		float AMOUNT = 10;
		if (Input.IsKeyPressed((int)KeyList.Right))
		{
			this.Position += new Vector2(AMOUNT, 0);
		}
		if (Input.IsKeyPressed((int)KeyList.Left))
		{
			this.Position += new Vector2(-AMOUNT, 0);
		}	
		if (Input.IsKeyPressed((int)KeyList.Up))
		{
			this.Position += new Vector2(0,  -AMOUNT);
		}
		if (Input.IsKeyPressed((int)KeyList.Down))
		{
			this.Position += new Vector2(0, AMOUNT);
		}
	}
}



