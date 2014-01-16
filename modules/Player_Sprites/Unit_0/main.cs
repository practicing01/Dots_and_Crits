function Module_Player_Sprite_Unit_0::create(%this)
{

exec("./assets/scripts/Player_Sprite/Player_Sprite_Load.cs");
exec("./assets/scripts/Player_Sprite/Player_Sprite_Unload.cs");

}

function Module_Player_Sprite_Unit_0::destroy(%this)
{

%this.Player_Sprite_Unload();

}
