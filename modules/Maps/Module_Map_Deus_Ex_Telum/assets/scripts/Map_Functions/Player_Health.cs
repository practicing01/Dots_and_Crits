function Module_Map_Deus_Ex_Telum::Player_Health(%this,%Player_Information)
{

if (%Player_Information.Health<=0)
{

commandToServer('Relay_Module_Function',%Player_Information.Sprite.Module_ID_Parent,"Action_Update_Health",%Player_Information.Game_Connection_Handle,2,100);

%this.Player_Spawn(%Player_Information.Sprite);

commandToServer('Relay_Module_Function',%Player_Information.Sprite.Module_ID_Parent,"Action_Position",%Player_Information.Game_Connection_Handle,%Player_Information.Sprite.Position);

}

}
