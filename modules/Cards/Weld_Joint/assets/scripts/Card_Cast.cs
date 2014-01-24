function Module_Card_Weld_Joint::Card_Cast(%this,%Script_Object_Player_Sprite_Target,%Script_Object_Player_Sprite_Target_0)
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

/****************************************************************************************************/

%Parameter_4=0;
%Parameter_5=0;
%Parameter_6=0;
%Parameter_7=0;

if (%Script_Object_Player_Sprite_Target_0.class$="Class_Sprite_Player")
{

%Parameter_5=%Script_Object_Player_Sprite_Target_0.Script_Object_Parent.Game_Connection_Handle;

}
else
{

%Parameter_4=1;

%Parameter_5=%Script_Object_Player_Sprite_Target_0.Module_ID_Parent;

%Parameter_6=%Script_Object_Player_Sprite_Target_0.Game_Connection_Handle;

%Parameter_7=%Script_Object_Player_Sprite_Target_0.Object_Index;

}

/****************************************************************************************************/

commandToServer('Relay_Module_Function',Module_Card_Weld_Joint,"Action_Cast",
%Parameter_0,
%Parameter_1,
%Parameter_2,
%Parameter_3,
%Parameter_4,
%Parameter_5,
%Parameter_6,
%Parameter_7);

}
