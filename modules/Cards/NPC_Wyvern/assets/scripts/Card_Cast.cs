function Module_Card_NPC_Wyvern::Card_Cast(%this,%Script_Object_Player_Sprite_Target,%Vector_2D_World_Point)
{

%this.NPC_Wyvern_Count++;

commandToServer('Relay_Module_Function',Module_Card_NPC_Wyvern,"Action_Cast",
%Script_Object_Player_Sprite_Target.Game_Connection_Handle,
%Vector_2D_World_Point,%this.NPC_Wyvern_Count);

}
