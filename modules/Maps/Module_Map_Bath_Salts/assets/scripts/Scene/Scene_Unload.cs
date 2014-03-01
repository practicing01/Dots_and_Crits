function Module_Map_Bath_Salts::Scene_Unload(%this)
{

Canvas.popDialog(%this.Gui_Text_Score);

cancel(%this.Camera_Move_Schedule.Schedule_Handle);

%this.Simset_Objects.deleteObjects();

%this.Simset_Objects.delete();

%this.Ass_Unload();

%this.Simset_Portal_Spawn.delete();

%this.Camera_Move_Schedule.delete();

%this.Player_Move_Schedule.delete();

Window_Dots_and_Crits.removeInputListener(%this.Script_Object_Input_Controller);

%this.Script_Object_Input_Controller.delete();

}
