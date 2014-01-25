function Module_Player_Sprite_Lelur::onResize(%this,%Sprite_Player)
{

%Sprite_Player.clearCollisionShapes();

/*Since the sprite is 256*256 but we want a 128*128 collision box, we scale it.*/

%Scaled_Size=%Sprite_Player.Size;

%Scaled_Size.X/=2;

%Scaled_Size.Y/=2;

%Sprite_Player.createPolygonBoxCollisionShape(%Scaled_Size);

}
