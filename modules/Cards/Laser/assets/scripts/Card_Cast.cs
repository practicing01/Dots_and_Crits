function Module_Card_Laser::Card_Cast(%this,%Script_Object_Player_Sprite_Target,%World_Position)
{

if (%Script_Object_Player_Sprite_Target!=0)
{

commandToServer('Relay_Module_Function',Module_Card_Laser,"Action_Cast",
%Script_Object_Player_Sprite_Target.Game_Connection_Handle,%World_Position);

}
else
{

commandToServer('Relay_Module_Function',Module_Card_Laser,"Action_Cast",
0,%World_Position);

}

}
