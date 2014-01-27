function Class_Portal_Bearer_Portal::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.class$="Class_Sprite_Player")
{

%Colliding_Object.cancelMoveTo(true);

/*************************************/

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

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

return;

}

/*************************************/

if (!%this.Bool_Portal_Projectile_Type)//In
{

%Vector_To_Direction=Vector2Direction(%Player_Object.Sprite_Portal_Out.Angle,
Vector2Length(%Colliding_Object.size)/2+Vector2Length(%Player_Object.Sprite_Portal_Out.size)/2);

%Colliding_Object.Position=Vector2Add(%Player_Object.Sprite_Portal_Out.Position,%Vector_To_Direction);

%Colliding_Object.onMoveToComplete();

}
else
{

%Vector_To_Direction=Vector2Direction(%Player_Object.Sprite_Portal_In.Angle,
Vector2Length(%Colliding_Object.size)/2+Vector2Length(%Player_Object.Sprite_Portal_In.size)/2);

%Colliding_Object.Position=Vector2Add(%Player_Object.Sprite_Portal_In.Position,%Vector_To_Direction);

%Colliding_Object.onMoveToComplete();

}

/*************************************/

}
else if (%Colliding_Object.class!$="Class_Portal_Bearer_Projectile")
{

/*************************************/

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

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

return;

}

/*************************************/

if (!%this.Bool_Portal_Projectile_Type)//In
{

%Vector_To_Direction=Vector2Direction(%Player_Object.Sprite_Portal_Out.Angle,
Vector2Length(%Colliding_Object.size)/2+Vector2Length(%Player_Object.Sprite_Portal_Out.size)/2);

%Colliding_Object.Position=Vector2Add(%Player_Object.Sprite_Portal_Out.Position,%Vector_To_Direction);

}
else
{

%Vector_To_Direction=Vector2Direction(%Player_Object.Sprite_Portal_In.Angle,
Vector2Length(%Colliding_Object.size)/2+Vector2Length(%Player_Object.Sprite_Portal_In.size)/2);

%Colliding_Object.Position=Vector2Add(%Player_Object.Sprite_Portal_In.Position,%Vector_To_Direction);

}

/*************************************/

}

}
