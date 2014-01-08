function Module_Map_Deathball_Valley::Scene_Unload(%this)
{

cancel(%this.Camera_Move_Schedule.Schedule_Handle);

%this.Ass_Unload();

%this.Simset_Portal_Spawn.delete();

%this.Camera_Move_Schedule.delete();

%this.Player_Move_Schedule.delete();

%this.Script_Object_Input_Controller.delete();

}
