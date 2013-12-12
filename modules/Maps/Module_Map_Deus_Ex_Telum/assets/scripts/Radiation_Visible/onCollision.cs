function Class_Deus_Ex_Telum_Visible::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.SceneGroup==25||%Colliding_Object.SceneGroup==26)
{

if (%Colliding_Object.Health>0&&%Colliding_Object.class$="Class_Deus_Ex_Telum_Mech")
{

Module_Map_Deus_Ex_Telum.Player_Spawn(%this.Handle_Parent);

}
else
{

%this.safeDelete();

}

}

}
