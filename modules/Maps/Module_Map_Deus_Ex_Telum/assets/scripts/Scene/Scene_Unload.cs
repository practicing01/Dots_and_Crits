function Module_Map_Deus_Ex_Telum::Scene_Unload(%this)
{

cancel(%this.Camera_Move_Schedule.Schedule_Handle);

cancel(%this.Schedule_Handle_Radiate_Visible);

%this.Ass_Unload();

%this.Simset_Portal_Spawn.delete();

%this.Camera_Move_Schedule.delete();

%this.Player_Move_Schedule.delete();

%this.Simset_Objects.deleteObjects();

%this.Simset_Objects.delete();

%this.Simset_Goal_Spawn_Vectors.deleteObjects();

%this.Simset_Goal_Spawn_Vectors.delete();

}
