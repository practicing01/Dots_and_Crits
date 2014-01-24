exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Initialize_Variables.cs");
exec("./Card_Initialize.cs");
exec("./Relay_Module_Function.cs");
exec("./Card_Cast.cs");
exec("./Input_Touch/Input_Touch.cs");
exec("./onAction/Actions.cs");
exec("./Actions/Actions.cs");
exec("./Class_NPC_Wyvern/Class_NPC_Wyvern.cs");
exec("./Class_NPC_Wyvern_Fire_Ball/Class_NPC_Wyvern_Fire_Ball.cs");
exec("./Class_NPC_Wyvern_Explosion/Class_NPC_Wyvern_Explosion.cs");

function Module_Card_NPC_Wyvern::Card_Load(%this)
{

%this.Ass_Load();

%this.Initialize_Variables();

%this.Card_Initialize();

}
