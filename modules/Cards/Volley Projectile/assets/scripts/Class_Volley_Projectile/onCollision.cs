function Class_Volley_Projectile::onCollision(%this,%Colliding_Object,%Collision_Details)
{

%Bool_Delete=false;

if (%Colliding_Object.class$="Class_Composite_Sprite_Player")
{

if (%Colliding_Object.Script_Object_Parent.Game_Connection_Handle!=%this.Game_Connection_Handle)
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(%Colliding_Object.Script_Object_Parent,%Colliding_Object.Script_Object_Parent.Game_Connection_Handle,1,10);

%Bool_Delete=true;

}

}
else if (%Colliding_Object.class$="Class_Volley_Projectile")
{

if (%Colliding_Object.Game_Connection_Handle!=%this.Game_Connection_Handle)
{

%Colliding_Object.Update_Health(-10);

%Bool_Delete=true;

}

}

if (%Bool_Delete)
{

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

}

}
