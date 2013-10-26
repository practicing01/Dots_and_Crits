function Class_Deathball::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Composite_Sprite_Player")
{
echo("Collided with player");
%Colliding_Object.Module_ID_Parent.Action_Update_Health(%Colliding_Object.Script_Object_Parent,-10);

}
else
{
echo("Collided with object");
%Colliding_Object.Update_Health(-10);

}

}
