using System;
using Godot;
using Dictionary = Godot.Collections.Dictionary;
using Array = Godot.Collections.Array;

public partial class Character : Godot.CharacterBody3D
{
	
	
	// TODO:
	// * add ways to get over obstacles
	// * implement fall damage
	// * hold crouch key to increase gravity ?
	// * hold jump key to lower gravity strength ?
	// * change gravity into a non-linear acceleration ?
	
	/* movement physics */
	
	public const double MIN_JUMP_VELOCITY = 3.5;
	public const double MAX_Y_SPEED = 10.0;
	
	public const Godot.Vector3 XZ = Vector3(1.0,0.0,1.0);
	public const Godot.Vector3 YZ = Vector3(0.0,1.0,1.0);
	public const Godot.Vector3 XY = Vector3(1.0,1.0,0.0);
	
	public static Godot.Object gravity = ProjectSettings.get_setting();
	
	public Godot.Object coyoteTime = Utils.createTimer(self,0.15);
	public Godot.Object jumpCoolDown = Utils.createTimer(self,0.15);
	
	
	
}
