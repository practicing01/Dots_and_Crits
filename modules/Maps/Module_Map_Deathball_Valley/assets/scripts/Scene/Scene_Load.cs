exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Initialize_Variables.cs");
exec("./Scene_Initialize.cs");
exec("./../Map_Functions/Map_Functions.cs");
exec("./../../gui/Gui.cs");
exec("./../Buttons/Buttons.cs");
exec("./../Keyboard/Keyboard.cs");

function Module_Map_Deathball_Valley::Scene_Load(%this)
{

%this.Ass_Load();

Cancel_All_Schedules();

Scene_Dots_and_Crits.clear();

%this.Scene_Current=TamlRead("./../../scenes/Module_Map_Deathball_Valley.scene.taml");

if (!isObject(%this.Scene_Current))
{

echo("Couldn't read scene taml.");

}

%this.Scene_Current.setName("");
Scene_Set_Custom(%this.Scene_Current);

%this.Initialize_Variables();

%this.Scene_Initialize();

}
