function Module_Card_Sword::Card_Cast(%this,%Script_Object_Player_Sprite_Target)
{

%this.Sword_Count++;

commandToServer('Relay_Module_Function',Module_Card_Sword,"Action_Cast",
%Script_Object_Player_Sprite_Target.Game_Connection_Handle,%this.Sword_Count);

}
