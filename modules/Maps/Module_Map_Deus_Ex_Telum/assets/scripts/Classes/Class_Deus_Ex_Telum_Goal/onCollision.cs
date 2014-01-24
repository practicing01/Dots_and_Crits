function Class_Deus_Ex_Telum_Goal::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.class$="Class_Sprite_Player")
{

echo("Reached Goal!");

%Random_Vector=%this.Module_ID_Parent.Simset_Goal_Spawn_Vectors.getObject(
getRandom(0,%this.Module_ID_Parent.Simset_Goal_Spawn_Vectors.getCount()-1));

%this.Position=%Random_Vector.Vector_2D;

}

}
