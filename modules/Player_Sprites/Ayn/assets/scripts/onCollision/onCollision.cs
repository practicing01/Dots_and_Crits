function Module_Player_Sprite_Ayn::onCollision(%this,%Composite_Sprite_Player,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,0))){return;}

%Player_Information=%Composite_Sprite_Player.Script_Object_Parent;

//%Player_Information.Composite_Sprite.setLinearDamping(%Player_Information.Linear_Damping);

}
