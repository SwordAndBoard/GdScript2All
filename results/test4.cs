using System;
using Godot;
using Dictionary = Godot.Collections.Dictionary;
using Array = Godot.Collections.Array;



// line comment

/* multiline
   comment
*/

[Tool]
public partial class test4 : Godot.Node
{
	public partial class Nested1 : test
	{
		
		
		
	}
	public partial class Nested2 : Godot.Object
	{
		
		public partial class Nested3 : Godot.Object
		{
			
			
			
			
		}
		
	}
	enum Enum0 {UNIT_NEUTRAL, UNIT_ENEMY, UNIT_ALLY}
	enum Named {THING_1, THING_2, ANOTHER_THING = -1}
	
	public Godot.Variant foo;
	public int i = 0;
	public const string str = ;
	public string big_str = ;
	protected bool _protected_bool = true;
	public Array array = new Array{0,1,2,};
	
	[Export]
	
	public Array<string> string_array = new Array{,,};
	
	[Export("param1, param2")]
	
	public Dictionary dict = new Dictionary{{0,1},{1,2},{2,3},};
	
	[Export(PropertyHint.Flags,"Self:4, Allies:8, Foes:16")]
	
	public int parenthesis = (42);
	
	public Godot.Variant variable = foo;
	public Godot.Variant reference = foo.bar;
	public Godot.Variant function = foo();
	public Godot.Variant functionParams = foo(a,b);
	public Godot.Variant method = foo.bar();
	public Godot.Variant functionMethodParams = foo(a,b).bar(c,d);
	public Godot.Variant refMethod = foo.bar.baz();
	public Godot.Variant methodRef = foo.bar().baz;
	public Godot.Variant subscription = dict[0];
	
	// test type inference on local class members
	public int j = i;
	public string k = string_array[0];
	
	// determine type based on godot doc
	public double x = new Vector3().x;
	public static Godot.Variant gravity = Godot.ProjectSettings.get_setting();
	public Dictionary aClass = Godot.ProjectSettings.get_global_class_list()[10];
	public const int flag = Godot.RenderingServer.NO_INDEX_ARRAY;
	
	// Gdscript special syntax
	public Godot.Node get_node = get_node();
	public Godot.Node get_unique_node = get_node();
	public Godot.Variant preload_resource = preload();
	public Godot.Variant load_resource = load();
	
	public int delayed = 1;
	// comment
	public int delayed_wComment = 2;
	
	public double arithmetic =  - j * 0.5;
	public bool comparison = arithmetic >= 0.5 && arithmetic == 6.0;
	public bool ternary = ( false && true ? !true : 5 > 6 );
	public bool nested_ternary = ( false ? true : ( true ? 5 > 6 : 7 < 0 ) );
	
	// methods
	
}
