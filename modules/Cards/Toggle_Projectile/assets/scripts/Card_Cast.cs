function Module_Card_Toggle_Projectile::Card_Cast(%this,%Script_Object_Player_Sprite_Target)
{

commandToServer('Relay_Module_Function',Module_Card_Toggle_Projectile,"Action_Cast",
%Script_Object_Player_Sprite_Target.Game_Connection_Handle);

}
