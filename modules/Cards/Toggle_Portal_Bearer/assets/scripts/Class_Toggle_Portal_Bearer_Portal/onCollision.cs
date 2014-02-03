function Class_Toggle_Portal_Bearer_Portal::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class!$="Class_Toggle_Portal_Bearer_Projectile"
&&%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (!isObject(%this.Sprite_Connected_Portal)||%Colliding_Object.class$="Class_Toggle_Portal_Bearer_Projectile")
{

%Player_Object=0;

for (%x=0;%x<%this.Module_ID_Parent.Simset_Player_Information.getCount();%x++)
{

%Player_Object=%this.Module_ID_Parent.Simset_Player_Information.getObject(%x);

if (%Player_Object.Player_Information.Game_Connection_Handle==%this.Game_Connection_Handle)
{

break;

}
else
{

%Player_Object=0;

}

}

if (%Player_Object==0)
{

if (%this.Module_ID_Parent.Simset_Objects.isMember(%this))
{

%this.Module_ID_Parent.Simset_Objects.remove(%this);

}

%this.safeDelete();

return;

}

/****************************/

if (%Colliding_Object.class$="Class_Sprite_Player")
{

if (%Player_Object.Simset_Previous_Portal.isMember(%this))
{

%Player_Object.Simset_Previous_Portal.remove(%this);

}

if (%this.Module_ID_Parent.Simset_Objects.isMember(%this))
{

%this.Module_ID_Parent.Simset_Objects.remove(%this);

}

%this.safeDelete();

return;

}

/****************************/

%Player_Object_0=0;

for (%x=0;%x<%Colliding_Object.Module_ID_Parent.Simset_Player_Information.getCount();%x++)
{

%Player_Object_0=%Colliding_Object.Module_ID_Parent.Simset_Player_Information.getObject(%x);

if (%Player_Object_0.Player_Information.Game_Connection_Handle==%Colliding_Object.Game_Connection_Handle)
{

break;

}
else
{

%Player_Object_0=0;

}

}

/****************************/

if (%Player_Object_0==0)
{

if (%Colliding_Object.Module_ID_Parent.Simset_Objects.isMember(%Colliding_Object))
{

%Colliding_Object.Module_ID_Parent.Simset_Objects.remove(%Colliding_Object);

}

%Colliding_Object.safeDelete();

return;

}

if (%Player_Object_0.Simset_Previous_Portal.isMember(%Colliding_Object))
{

%Player_Object_0.Simset_Previous_Portal.remove(%Colliding_Object);

}

if (%Colliding_Object.Module_ID_Parent.Simset_Objects.isMember(%Colliding_Object))
{

%Colliding_Object.Module_ID_Parent.Simset_Objects.remove(%Colliding_Object);

}

%Colliding_Object.safeDelete();

if (%Player_Object.Simset_Previous_Portal.isMember(%this))
{

%Player_Object.Simset_Previous_Portal.remove(%this);

}

if (%this.Module_ID_Parent.Simset_Objects.isMember(%this))
{

%this.Module_ID_Parent.Simset_Objects.remove(%this);

}

%this.safeDelete();

return;

}

//if (%Colliding_Object.class!$="Class_Toggle_Portal_Bearer_Projectile")
//{

//%Colliding_Object.cancelMoveTo(true);

%Colliding_Object_Size=0;

if (%Colliding_Object.size.X>%Colliding_Object.size.Y){%Colliding_Object_Size=%Colliding_Object.size.X;}
else {%Colliding_Object_Size=%Colliding_Object.size.Y;}

%Vector_2D_To_Direction=Vector2Direction(%this.Sprite_Connected_Portal.Angle,%Colliding_Object_Size);

%Vector_2D_Offset=Vector2Add(%this.Sprite_Connected_Portal.Vector_2D_Position_Offset,%Vector_2D_To_Direction);

%Colliding_Object.Position=%Vector_2D_Offset;

//%Colliding_Object.onMoveToComplete();

//}

}
