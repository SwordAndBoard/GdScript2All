using System;
using Godot;
using Dictionary = Godot.Collections.Dictionary;
using Array = Godot.Collections.Array;

public partial class Character : Godot.CharacterBody3D
{
	
	
	/* 3D character controller
	usable for both players and AI
	for players, input is handled an overlay script which sets local_dir and view_dir
	speed and acceleration is based on movementState which is a Ressource (see MovementState.gd)
	*/
	
	// TODO:
	// * add ways to get over obstacles
	// * implement fall damage
	// * hold crouch key to increase gravity ?
	// * hold jump key to lower gravity strength ?
	// * change gravity into a non-linear acceleration ?
	
	/* movement physics */
	
	public const double MIN_JUMP_VELOCITY = 3.5;
	public const double MAX_Y_SPEED = 10.0;
	
	public const Godot.Vector3 XZ = new Vector3(1.0,0.0,1.0);
	public const Godot.Vector3 YZ = new Vector3(0.0,1.0,1.0);
	public const Godot.Vector3 XY = new Vector3(1.0,1.0,0.0);
	
	public static Godot.Variant gravity = Godot.ProjectSettings.get_setting("physics/3d/default_gravity");
	
	public Godot.Variant coyoteTime = Utils.createTimer(this,0.15);
	public Godot.Variant jumpCoolDown = Utils.createTimer(this,0.15);
	
	
	protected void _process(double delta)
	{
		// in air
		
	}
	//PANIC! <not is_on_floor ( ) :> unexpected at Token(type='UNARY', value='not', lineno=34, index=893, end=896)
	//PANIC! <velocity . y = clampf ( velocity . y - gravity * delta , - MAX_Y_SPEED , MAX_Y_SPEED )> unexpected at Token(type='TEXT', value='velocity', lineno=35, index=914, end=922)
}