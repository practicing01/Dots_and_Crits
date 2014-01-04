function Module_Map_Bath_Salts::Scene_Initialize(%this)
{

echo("Bath Salts initialized.");

exec("./Scene_Initialize/Initialize_Floor/Initialize_Floor.cs");
exec("./Scene_Initialize/Initialize_DWO/Initialize_DWO.cs");
exec("./Scene_Initialize/Initialize_Monsters/Initialize_Monsters.cs");
exec("./Scene_Initialize/Initialize_Survivors/Initialize_Survivors.cs");

%this.Keyboard_Bind();

%this.Gui_Scroll_Arrows_Spawn();

%this.Gui_Move_Arrows_Spawn();

%this.Initialize_Floor();

%this.Initialize_DWO();

%this.Initialize_Monsters();

%this.Initialize_Survivors();

/************************************************************************/

//Create spawn portal.

%Scene_Object_Portal_Spawn=new SceneObject()
{

Position=Scale_Vector_To_Camera_By_Resolution("0 0","1280 800");
class="Class_Portal_Spawn";
size="10 10";
BodyType="static";

};

Scene_Dots_and_Crits.add(%Scene_Object_Portal_Spawn);

%this.Simset_Portal_Spawn.add(%Scene_Object_Portal_Spawn);

}
