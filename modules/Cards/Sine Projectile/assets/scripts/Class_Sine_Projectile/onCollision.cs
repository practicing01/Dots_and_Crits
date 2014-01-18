function Class_Sine_Projectile::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Composite_Sprite_Player")
{

if (%Colliding_Object.Script_Object_Parent.Game_Connection_Handle!=%this.Game_Connection_Handle)
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(%Colliding_Object.Script_Object_Parent,%Colliding_Object.Script_Object_Parent.Game_Connection_Handle,1,10);

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

}

}
else if (%Colliding_Object.Game_Connection_Handle!=%this.Game_Connection_Handle)
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(-1,%Colliding_Object.Game_Connection_Handle,%Colliding_Object.Object_Index,1,10);

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

}

}
