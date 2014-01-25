function Module_Player_Sprite_Ayn::onResize(%this,%Sprite_Player)
{

%Sprite_Player.clearCollisionShapes();

%Sprite_Player.createPolygonBoxCollisionShape(%Sprite_Player.Size);

}
