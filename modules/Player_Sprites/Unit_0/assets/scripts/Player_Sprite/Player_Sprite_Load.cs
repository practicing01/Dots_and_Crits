exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Initialize_Variables.cs");
exec("./Player_Sprite_Initialize.cs");
exec("./../Buttons/Buttons.cs");
exec("./../../gui/Gui.cs");
exec("./Player_Sprite_Spawn.cs");
exec("./Player_Sprite_Data_Remove.cs");
exec("./../Animation_Reset/Animation_Reset.cs");
exec("./../onAnimationEnd/onAnimationEnd.cs");
exec("./Relay_Module_Function.cs");
exec("./../Actions/Actions.cs");
exec("./../Input_Touch/Input_Touch.cs");
exec("./../Movement/onMoveToComplete.cs");
exec("./../onCollision/onCollision.cs");
exec("./../Player_Dismount_Objects/Player_Dismount_Objects.cs");
exec("./../onResize/onResize.cs");

function Module_Player_Sprite_Unit_0::Player_Sprite_Load(%this)
{

%this.Ass_Load();

%this.Initialize_Variables();

%this.Player_Sprite_Initialize();

}
