function Module_Player_Sprite_Gill_Balentine::onCollision(%this,%Sprite_Player,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,0))){return;}

%Player_Information=%Sprite_Player.Script_Object_Parent;

//%Player_Information.Sprite.setLinearDamping(%Player_Information.Linear_Damping);

}
