function Module_Card_Shield::Card_Cast(%this,%Script_Object_Player_Sprite_Target,%Vector_2D_World_Point)
{

%this.Shield_Count+=4;

commandToServer('Relay_Module_Function',Module_Card_Shield,"Action_Cast",
%Script_Object_Player_Sprite_Target.Game_Connection_Handle,
%Vector_2D_World_Point,%this.Shield_Count);

}
