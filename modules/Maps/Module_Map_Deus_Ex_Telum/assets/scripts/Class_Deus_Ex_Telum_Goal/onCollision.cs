function Class_Deus_Ex_Telum_Goal::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Composite_Sprite_Player")
{

echo("Reached Goal!");

}
/*else
{

%Colliding_Object.Update_Health(-10);

}*/

}
