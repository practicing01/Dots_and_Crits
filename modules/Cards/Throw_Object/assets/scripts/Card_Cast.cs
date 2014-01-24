function Module_Card_Throw_Object::Card_Cast(%this,%Script_Object_Player_Sprite_Target,%Vector_2D_World_Point)
{

%Parameter_0=0;
%Parameter_1=0;
%Parameter_2=0;
%Parameter_3=0;

if (%Script_Object_Player_Sprite_Target.class$="Class_Sprite_Player")
{

%Parameter_1=%Script_Object_Player_Sprite_Target.Script_Object_Parent.Game_Connection_Handle;

}
else
{

%Parameter_0=1;

%Parameter_1=%Script_Object_Player_Sprite_Target.Module_ID_Parent;

%Parameter_2=%Script_Object_Player_Sprite_Target.Game_Connection_Handle;

%Parameter_3=%Script_Object_Player_Sprite_Target.Object_Index;

}

commandToServer('Relay_Module_Function',Module_Card_Throw_Object,"Action_Cast",
%Parameter_0,
%Parameter_1,
%Parameter_2,
%Parameter_3,
%Vector_2D_World_Point);

}
