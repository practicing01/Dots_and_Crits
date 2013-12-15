function Module_Card_Portal_Bearer::Card_Cast(%this,%Script_Object_Player_Sprite_Target,%World_Position)
{

%this.Projectile_Count++;

if (%Script_Object_Player_Sprite_Target!=0)
{

commandToServer('Relay_Module_Function',Module_Card_Portal_Bearer,"Action_Cast",
%Script_Object_Player_Sprite_Target.Game_Connection_Handle,%World_Position,%this.Projectile_Count);

}
else
{

commandToServer('Relay_Module_Function',Module_Card_Portal_Bearer,"Action_Cast",
0,%World_Position,%this.Projectile_Count);

}

}
