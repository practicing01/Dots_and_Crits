function Module_Card_Volley_Projectile::Card_Cast(%this,%Script_Object_Player_Sprite_Target,%Vector_2D_World_Point)
{

%this.Volley_Projectile_Count+=7;

commandToServer('Relay_Module_Function',Module_Card_Volley_Projectile,"Action_Cast",
%Script_Object_Player_Sprite_Target.Game_Connection_Handle,
%Vector_2D_World_Point,%this.Volley_Projectile_Count);

}
