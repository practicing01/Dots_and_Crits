exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Initialize_Variables.cs");
exec("./Scene_Initialize.cs");
exec("./../Buttons/Buttons.cs");

function Module_Gui_Instructions_Menu::Scene_Load(%this)
{

%this.Ass_Load();

Cancel_All_Schedules();

Scene_Dots_and_Crits.clear();

%this.Scene_Current=TamlRead("./../../scenes/Module_Gui_Instructions_Menu.scene.taml");

if (!isObject(%this.Scene_Current))
{

echo("Couldn't read scene taml.");

}

%this.Scene_Current.setName("");
Scene_Set_Custom(%this.Scene_Current);

if (!isObject(Gui_Instructions_Menu))
{

Dots_and_Crits.add(TamlRead("./../../gui/Gui_Instructions_Menu.gui.taml"));

}

Canvas.pushDialog(Gui_Instructions_Menu);

%this.Initialize_Variables();

%this.Scene_Initialize();

}
