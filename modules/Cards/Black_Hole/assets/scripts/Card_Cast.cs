function Module_Card_Black_Hole::Card_Cast(%this,%Script_Object_Player_Sprite_Target,%Vector_2D_World_Point)
{

%this.Black_Hole_Count++;

commandToServer('Relay_Module_Function',Module_Card_Black_Hole,"Action_Cast",
%Script_Object_Player_Sprite_Target.Game_Connection_Handle,
%Vector_2D_World_Point,%this.Black_Hole_Count);

}
