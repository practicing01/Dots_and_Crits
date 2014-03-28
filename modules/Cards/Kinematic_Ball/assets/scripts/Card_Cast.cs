function Module_Card_Kinematic_Ball::Card_Cast(%this,%Script_Object_Player_Sprite_Target,%Vector_2D_World_Point)
{

%this.Kinematic_Ball_Count++;

commandToServer('Relay_Module_Function',Module_Card_Kinematic_Ball,"Action_Cast",
%Script_Object_Player_Sprite_Target.Game_Connection_Handle,
%Vector_2D_World_Point,%this.Kinematic_Ball_Count);

}
