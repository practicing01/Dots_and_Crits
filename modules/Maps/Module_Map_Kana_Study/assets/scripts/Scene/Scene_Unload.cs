function Module_Map_Kana_Study::Scene_Unload(%this)
{

cancel(%this.Camera_Move_Schedule.Schedule_Handle);

%this.Ass_Unload();

%this.Simset_Portal_Spawn.delete();

%this.Camera_Move_Schedule.delete();

%this.Player_Move_Schedule.delete();

%this.Script_Object_Input_Controller.delete();

echo("Deleting dictionary.");

%this.Simset_Dictionary.deleteObjects();

%this.Simset_Dictionary.delete();

echo("Deleting hiragana characters.");

%this.Simset_Map_Hiragana.deleteObjects();

%this.Simset_Map_Hiragana.delete();

echo("Deleting katakana characters.");

%this.Simset_Map_Katakana.deleteObjects();

%this.Simset_Map_Katakana.delete();

}
