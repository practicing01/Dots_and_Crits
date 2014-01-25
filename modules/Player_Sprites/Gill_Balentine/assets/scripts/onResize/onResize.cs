function Module_Player_Sprite_Gill_Balentine::onResize(%this,%Sprite_Player)
{

%Sprite_Player.clearCollisionShapes();

%Sprite_Player.createPolygonBoxCollisionShape(%Sprite_Player.Size);

}
