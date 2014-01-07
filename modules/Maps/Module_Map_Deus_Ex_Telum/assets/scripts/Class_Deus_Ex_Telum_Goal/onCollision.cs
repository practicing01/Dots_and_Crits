function Class_Deus_Ex_Telum_Goal::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Composite_Sprite_Player")
{

echo("Reached Goal!");

schedule(1000,0,"Module_Map_Deus_Ex_Telum::Scene_Unload",%this.Module_ID_Parent);

schedule(2000,0,"Module_Map_Deus_Ex_Telum::Scene_Load",%this.Module_ID_Parent);

}
/*else
{

%Colliding_Object.Update_Health(-10);

}*/

}
