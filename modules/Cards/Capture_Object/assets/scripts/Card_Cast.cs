function Module_Card_Capture_Object::Card_Cast(%this,%Script_Object_Player_Sprite_Target,%Vector_2D_World_Point)
{

%this.Capture_Object_Count+=2;

commandToServer('Relay_Module_Function',Module_Card_Capture_Object,"Action_Cast",
%Script_Object_Player_Sprite_Target.Game_Connection_Handle,
%Vector_2D_World_Point,%this.Capture_Object_Count);

}
