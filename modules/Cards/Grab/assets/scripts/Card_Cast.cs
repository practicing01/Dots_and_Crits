function Module_Card_Grab::Card_Cast(%this,%Script_Object_Player_Sprite_Target,%Scene_Object_Second_Target)
{

commandToServer('Relay_Module_Function',Module_Card_Grab,"Action_Cast",
%Script_Object_Player_Sprite_Target.Game_Connection_Handle,
%Scene_Object_Second_Target.Module_ID_Parent,
%Scene_Object_Second_Target.GameConnection_Handle,
%Scene_Object_Second_Target.Object_Index);

}
